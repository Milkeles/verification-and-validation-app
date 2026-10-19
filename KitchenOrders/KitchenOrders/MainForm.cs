using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KitchenOrders
{
    public partial class MainForm : Form
    {
        static readonly Regex validText = new Regex(@"^[\p{L}\d .,!\-„“""()]{1,40}$");
        Dictionary<string, string[]> menu = new Dictionary<string, string[]>
        {
            { "Предястия", new[] { "Таратор", "Шопска салата", "Снежанка", "Печени чушки" } },
            { "Основни", new[] { "Телешки бургер", "Мусака", "Пилешко филе", "Свинска пържола", "Паста с гъби", "Кюфтета на скара" } },
            { "Напитки", new[] { "Айрян", "Лимонада", "Кафе", "Минерална вода" } },
            { "Десерти", new[] { "Баница", "Палачинка", "Торта", "Крем карамел" } }
        };
        Dictionary<int, List<OrderLine>> orders = new Dictionary<int, List<OrderLine>>();
        int currentTable;
        int bonNo = 1;
        bool loading;
        readonly Color green = Color.FromArgb(42, 127, 98);

        public MainForm()
        {
            InitializeComponent();
            int[] seats = { 2, 2, 4, 4, 4, 6, 2, 8 };
            for (int i = 1; i <= 8; i++)
            {
                orders.Add(i, new List<OrderLine>());
                Button button = new Button();
                button.Size = new Size(100, 70);
                button.Text = "Маса " + i + "\n" + seats[i - 1] + " места";
                button.AccessibleName = "Маса " + i;
                button.Tag = i;
                button.TabIndex = i - 1;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.Gray;
                button.Click += TableClick;
                flpTables.Controls.Add(button);
            }
            foreach (string category in menu.Keys)
            {
                Button button = new Button();
                button.Text = category;
                button.AccessibleName = category;
                button.Size = new Size(150, 48);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.FromArgb(157, 184, 176);
                button.TabIndex = flpCategories.Controls.Count;
                button.Click += CategoryClick;
                flpCategories.Controls.Add(button);
            }
            string[] mods = { "без лук", "без сол", "двоен сос", "средно изпечено", "добре изпечено", "за вкъщи" };
            foreach (string mod in mods)
            {
                CheckBox box = new CheckBox();
                box.Text = mod;
                box.AutoSize = true;
                box.TabIndex = flpMods.Controls.Count;
                box.CheckedChanged += DetailsChanged;
                flpMods.Controls.Add(box);
            }
            ShowCategory("Предястия");
            ShowOrder(null);
        }

        void TableClick(object sender, EventArgs e)
        {
            currentTable = (int)((Button)sender).Tag;
            ShowOrder(null);
        }

        void CategoryClick(object sender, EventArgs e)
        {
            ShowCategory(((Button)sender).Text);
        }

        void ShowCategory(string category)
        {
            lblCategory.Text = category;
            foreach (Button button in flpCategories.Controls)
            {
                button.BackColor = button.Text == category ? green : Color.White;
                button.ForeColor = button.Text == category ? Color.White : Color.FromArgb(31, 59, 58);
            }
            while (flpDishes.Controls.Count > 0)
                flpDishes.Controls[0].Dispose();
            foreach (string dish in menu[category])
            {
                Button button = new Button();
                button.Text = dish;
                button.AccessibleName = dish;
                button.Size = new Size(150, 70);
                button.BackColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.FromArgb(157, 184, 176);
                button.TabIndex = flpDishes.Controls.Count;
                button.Click += DishClick;
                flpDishes.Controls.Add(button);
            }
        }

        void DishClick(object sender, EventArgs e)
        {
            AddLine(((Button)sender).Text);
        }

        bool AddLine(string name)
        {
            if (currentTable == 0)
            {
                MessageBox.Show(this, "Първо изберете маса.");
                return false;
            }
            List<OrderLine> order = orders[currentTable];
            OrderLine line = order.FirstOrDefault(x => x.Name == name && x.Mods.Count == 0 && x.Note.Length == 0);
            if (line != null)
                line.Qty = Math.Min(20, line.Qty + 1);
            else
            {
                if (order.Count >= 30)
                {
                    MessageBox.Show(this, "Максимум 30 реда в поръчка.");
                    return false;
                }
                line = new OrderLine { Name = name, Qty = 1 };
                order.Add(line);
            }
            ShowOrder(line);
            return true;
        }

        OrderLine SelectedLine()
        {
            return lvOrder.SelectedItems.Count == 0 ? null : (OrderLine)lvOrder.SelectedItems[0].Tag;
        }

        void ShowOrder(OrderLine selected)
        {
            loading = true;
            lvOrder.BeginUpdate();
            lvOrder.Items.Clear();
            lblTable.Text = currentTable == 0 ? "Изберете маса" : "Маса " + currentTable;
            if (currentTable != 0)
                foreach (OrderLine line in orders[currentTable])
                {
                    ListViewItem item = new ListViewItem(line.Qty.ToString());
                    item.SubItems.Add(line.Name);
                    item.SubItems.Add(Notes(line));
                    item.Tag = line;
                    lvOrder.Items.Add(item);
                    if (line == selected)
                    {
                        item.Selected = true;
                        item.Focused = true;
                        item.EnsureVisible();
                    }
                }
            lvOrder.EndUpdate();
            loading = false;
            LoadDetails();
            foreach (Button button in flpTables.Controls)
            {
                int table = (int)button.Tag;
                button.BackColor = table == currentTable ? green : orders[table].Count > 0 ? Color.FromArgb(255, 231, 168) : Color.White;
                button.ForeColor = table == currentTable ? Color.White : Color.FromArgb(31, 59, 58);
            }
        }

        static string Notes(OrderLine line)
        {
            List<string> parts = new List<string>(line.Mods);
            if (line.Note.Length > 0) parts.Add(line.Note);
            return string.Join(", ", parts);
        }

        void SelectionChanged(object sender, EventArgs e)
        {
            if (!loading) LoadDetails();
        }

        void LoadDetails()
        {
            loading = true;
            OrderLine line = SelectedLine();
            foreach (CheckBox box in flpMods.Controls)
            {
                box.Enabled = line != null;
                box.Checked = line != null && line.Mods.Contains(box.Text);
            }
            txtNote.Enabled = line != null;
            txtNote.Text = line == null ? "" : line.Note;
            txtNote.BackColor = Color.White;
            btnMinus.Enabled = btnPlus.Enabled = btnRemove.Enabled = line != null;
            loading = false;
        }

        void DetailsChanged(object sender, EventArgs e)
        {
            if (loading) return;
            OrderLine line = SelectedLine();
            if (line == null) return;
            line.Mods = flpMods.Controls.Cast<CheckBox>().Where(x => x.Checked).Select(x => x.Text).ToList();
            bool valid = txtNote.Text.Length == 0 || validText.IsMatch(txtNote.Text);
            txtNote.BackColor = valid ? Color.White : Color.MistyRose;
            if (valid) line.Note = txtNote.Text;
            RefreshSelected();
        }

        void RefreshSelected()
        {
            OrderLine line = SelectedLine();
            if (line == null) return;
            ListViewItem item = lvOrder.SelectedItems[0];
            item.Text = line.Qty.ToString();
            item.SubItems[2].Text = Notes(line);
        }

        void QuantityClick(object sender, EventArgs e)
        {
            OrderLine line = SelectedLine();
            if (line == null) return;
            line.Qty = Math.Max(1, Math.Min(20, line.Qty + (sender == btnPlus ? 1 : -1)));
            RefreshSelected();
        }

        void RemoveClick(object sender, EventArgs e)
        {
            OrderLine line = SelectedLine();
            if (line == null) return;
            List<OrderLine> order = orders[currentTable];
            int index = order.IndexOf(line);
            order.Remove(line);
            ShowOrder(order.Count == 0 ? null : order[Math.Min(index, order.Count - 1)]);
        }

        void OrderKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveClick(sender, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        void ExtraClick(object sender, EventArgs e)
        {
            if (!validText.IsMatch(txtExtra.Text))
            {
                MessageBox.Show(this, "Невалидно име на артикул.");
                txtExtra.Focus();
                return;
            }
            if (AddLine(txtExtra.Text)) txtExtra.Clear();
        }

        void ExtraKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExtraClick(sender, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        static string Center(string text)
        {
            return text.PadLeft(text.Length + Math.Max(0, (36 - text.Length) / 2));
        }

        void SendClick(object sender, EventArgs e)
        {
            if (currentTable == 0)
            {
                MessageBox.Show(this, "Първо изберете маса.");
                return;
            }
            List<OrderLine> order = orders[currentTable];
            if (order.Count == 0)
            {
                MessageBox.Show(this, "Поръчката е празна.");
                return;
            }
            if (!validText.IsMatch(txtWaiter.Text))
            {
                MessageBox.Show(this, "Въведете валидно име на сервитьор.");
                txtWaiter.Focus();
                return;
            }
            StringBuilder text = new StringBuilder();
            text.Append(Center("КУХНЯ") + "\r\n");
            text.Append(Center("МАСА " + currentTable) + "\r\n");
            text.Append(Center("Бон №" + bonNo + " · " + DateTime.Now.ToString("HH:mm")) + "\r\n");
            text.Append(Center("Сервитьор: " + txtWaiter.Text) + "\r\n");
            text.Append(new string('-', 36) + "\r\n");
            foreach (OrderLine line in order)
            {
                text.Append(line.Qty + "×  " + line.Name + "\r\n");
                foreach (string mod in line.Mods)
                    text.Append("      ► " + mod.ToUpper() + "\r\n");
                if (line.Note.Length > 0)
                    text.Append("      ► „" + line.Note.ToUpper() + "“\r\n");
            }
            text.Append(new string('-', 36) + "\r\n");
            string total = order.Sum(x => x.Qty).ToString();
            text.Append("Общо артикули" + total.PadLeft(36 - "Общо артикули".Length) + "\r\n");
            using (TicketForm ticket = new TicketForm(text.ToString(), "bon_" + currentTable + "_" + bonNo + ".txt"))
                ticket.ShowDialog(this);
            order.Clear();
            bonNo++;
            ShowOrder(null);
        }
    }
}
