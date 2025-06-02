namespace tech_assistant
{
    partial class BasketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketForm));
            back = new Button();
            goodsList = new FlowLayoutPanel();
            summ = new Label();
            regAnOrder = new Button();
            customer = new ComboBox();
            deliverDate = new DateTimePicker();
            label1 = new Label();
            status = new ComboBox();
            priority = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cheque = new Label();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(3, 3, 149);
            back.Font = new Font("Times New Roman", 10.2F);
            back.ForeColor = Color.White;
            back.Location = new Point(12, 306);
            back.Name = "back";
            back.Size = new Size(168, 30);
            back.TabIndex = 9;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // goodsList
            // 
            goodsList.AutoScroll = true;
            goodsList.BackColor = Color.White;
            goodsList.Font = new Font("Times New Roman", 10.2F);
            goodsList.Location = new Point(310, 12);
            goodsList.Name = "goodsList";
            goodsList.Size = new Size(770, 288);
            goodsList.TabIndex = 8;
            // 
            // summ
            // 
            summ.AutoSize = true;
            summ.Location = new Point(202, 311);
            summ.Name = "summ";
            summ.Size = new Size(62, 20);
            summ.TabIndex = 3;
            summ.Text = "Сумма: ";
            // 
            // regAnOrder
            // 
            regAnOrder.BackColor = Color.FromArgb(3, 3, 149);
            regAnOrder.Font = new Font("Times New Roman", 10.2F);
            regAnOrder.ForeColor = Color.White;
            regAnOrder.Location = new Point(912, 306);
            regAnOrder.Name = "regAnOrder";
            regAnOrder.Size = new Size(168, 30);
            regAnOrder.TabIndex = 10;
            regAnOrder.Text = "Выполнить заказ";
            regAnOrder.UseVisualStyleBackColor = false;
            regAnOrder.Click += regAnOrder_Click;
            // 
            // customer
            // 
            customer.FormattingEnabled = true;
            customer.Location = new Point(113, 12);
            customer.Name = "customer";
            customer.Size = new Size(191, 28);
            customer.TabIndex = 11;
            // 
            // deliverDate
            // 
            deliverDate.Location = new Point(13, 152);
            deliverDate.Name = "deliverDate";
            deliverDate.Size = new Size(190, 27);
            deliverDate.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 20);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 13;
            label1.Text = "Покупатель:";
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "новый", "подготовка", "в пути", "доставлен" });
            status.Location = new Point(113, 46);
            status.Name = "status";
            status.Size = new Size(191, 28);
            status.TabIndex = 14;
            // 
            // priority
            // 
            priority.FormattingEnabled = true;
            priority.Items.AddRange(new object[] { "низкий", "средний", "высокий", "срочный" });
            priority.Location = new Point(113, 80);
            priority.Name = "priority";
            priority.Size = new Size(191, 28);
            priority.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 49);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 16;
            label2.Text = "Статус:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 83);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 17;
            label3.Text = "Приоритет:";
            // 
            // cheque
            // 
            cheque.AutoSize = true;
            cheque.Location = new Point(-1, 118);
            cheque.Name = "cheque";
            cheque.Size = new Size(101, 20);
            cheque.TabIndex = 18;
            cheque.Text = "Номер Чека: ";
            // 
            // BasketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 344);
            Controls.Add(cheque);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(priority);
            Controls.Add(status);
            Controls.Add(label1);
            Controls.Add(deliverDate);
            Controls.Add(customer);
            Controls.Add(regAnOrder);
            Controls.Add(back);
            Controls.Add(summ);
            Controls.Add(goodsList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BasketForm";
            Text = "Корзина";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private FlowLayoutPanel goodsList;
        private Label summ;
        private Button regAnOrder;
        private ComboBox customer;
        private DateTimePicker deliverDate;
        private Label label1;
        private ComboBox status;
        private ComboBox priority;
        private Label label2;
        private Label label3;
        private Label cheque;
    }
}