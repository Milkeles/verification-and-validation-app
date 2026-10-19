using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KitchenOrders
{
    public class TicketForm : Form
    {
        public TicketForm(string text, string defaultName)
        {
            Text = "Кухненски бон";
            Size = new Size(420, 560);
            StartPosition = FormStartPosition.CenterParent;
            Font = new Font("Segoe UI", 10F);
            TextBox receipt = new TextBox();
            receipt.Multiline = true;
            receipt.ReadOnly = true;
            receipt.Dock = DockStyle.Fill;
            receipt.Font = new Font("Consolas", 11F);
            receipt.ScrollBars = ScrollBars.Vertical;
            receipt.BackColor = Color.White;
            receipt.WordWrap = false;
            receipt.Text = text;
            receipt.TabStop = false;
            FlowLayoutPanel bottom = new FlowLayoutPanel();
            bottom.Dock = DockStyle.Bottom;
            bottom.Height = 60;
            bottom.Padding = new Padding(6);
            Button save = new Button();
            save.Text = "&Запази във файл";
            save.Size = new Size(190, 44);
            save.TabIndex = 0;
            save.Click += delegate
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Текст (*.txt)|*.txt";
                    dialog.FileName = defaultName;
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                        File.WriteAllText(dialog.FileName, text, Encoding.UTF8);
                }
            };
            Button close = new Button();
            close.Text = "&Затвори";
            close.Size = new Size(130, 44);
            close.TabIndex = 1;
            close.Click += delegate { Close(); };
            bottom.Controls.Add(save);
            bottom.Controls.Add(close);
            Controls.Add(receipt);
            Controls.Add(bottom);
        }
    }
}
