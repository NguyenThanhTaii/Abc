namespace ToDoApplication
{
    partial class AddNewTaskForm
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

     
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDateFinish = new System.Windows.Forms.Label();
            this.lblDateCreate = new System.Windows.Forms.Label();
            this.dtmDateCreate = new System.Windows.Forms.DateTimePicker();
            this.dtmDateFinish = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitleNull = new System.Windows.Forms.Label();
            this.lblDesNull = new System.Windows.Forms.Label();
            this.lblFinishdateEarlier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(86, 120);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(236, 117);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(85, 187);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(236, 183);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 80);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDateFinish
            // 
            this.lblDateFinish.AutoSize = true;
            this.lblDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFinish.Location = new System.Drawing.Point(86, 385);
            this.lblDateFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFinish.Name = "lblDateFinish";
            this.lblDateFinish.Size = new System.Drawing.Size(75, 16);
            this.lblDateFinish.TabIndex = 0;
            this.lblDateFinish.Text = "Date Finish";
            // 
            // lblDateCreate
            // 
            this.lblDateCreate.AutoSize = true;
            this.lblDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreate.Location = new System.Drawing.Point(85, 320);
            this.lblDateCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateCreate.Name = "lblDateCreate";
            this.lblDateCreate.Size = new System.Drawing.Size(80, 16);
            this.lblDateCreate.TabIndex = 0;
            this.lblDateCreate.Text = "Date Create";
            // 
            // dtmDateCreate
            // 
            this.dtmDateCreate.Location = new System.Drawing.Point(236, 314);
            this.dtmDateCreate.Margin = new System.Windows.Forms.Padding(4);
            this.dtmDateCreate.Name = "dtmDateCreate";
            this.dtmDateCreate.Size = new System.Drawing.Size(265, 22);
            this.dtmDateCreate.TabIndex = 2;
            // 
            // dtmDateFinish
            // 
            this.dtmDateFinish.Location = new System.Drawing.Point(236, 379);
            this.dtmDateFinish.Margin = new System.Windows.Forms.Padding(4);
            this.dtmDateFinish.Name = "dtmDateFinish";
            this.dtmDateFinish.Size = new System.Drawing.Size(265, 22);
            this.dtmDateFinish.TabIndex = 3;
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.Location = new System.Drawing.Point(127, 491);
            this.btnAddNewTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(100, 28);
            this.btnAddNewTask.TabIndex = 4;
            this.btnAddNewTask.Text = "Add";
            this.btnAddNewTask.UseVisualStyleBackColor = true;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 491);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitleNull
            // 
            this.lblTitleNull.AutoSize = true;
            this.lblTitleNull.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitleNull.Location = new System.Drawing.Point(233, 143);
            this.lblTitleNull.Name = "lblTitleNull";
            this.lblTitleNull.Size = new System.Drawing.Size(78, 16);
            this.lblTitleNull.TabIndex = 6;
            this.lblTitleNull.Text = "Title not null";
            this.lblTitleNull.Visible = false;
            // 
            // lblDesNull
            // 
            this.lblDesNull.AutoSize = true;
            this.lblDesNull.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDesNull.Location = new System.Drawing.Point(233, 280);
            this.lblDesNull.Name = "lblDesNull";
            this.lblDesNull.Size = new System.Drawing.Size(120, 16);
            this.lblDesNull.TabIndex = 7;
            this.lblDesNull.Text = "Description not null";
            this.lblDesNull.Visible = false;
            // 
            // lblFinishdateEarlier
            // 
            this.lblFinishdateEarlier.AutoSize = true;
            this.lblFinishdateEarlier.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFinishdateEarlier.Location = new System.Drawing.Point(233, 418);
            this.lblFinishdateEarlier.Name = "lblFinishdateEarlier";
            this.lblFinishdateEarlier.Size = new System.Drawing.Size(214, 16);
            this.lblFinishdateEarlier.TabIndex = 8;
            this.lblFinishdateEarlier.Text = "Finish date is later than create date";
            this.lblFinishdateEarlier.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add task";
            // 
            // AddNewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(587, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFinishdateEarlier);
            this.Controls.Add(this.lblDesNull);
            this.Controls.Add(this.lblTitleNull);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNewTask);
            this.Controls.Add(this.dtmDateFinish);
            this.Controls.Add(this.dtmDateCreate);
            this.Controls.Add(this.lblDateCreate);
            this.Controls.Add(this.lblDateFinish);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddNewTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDateFinish;
        private System.Windows.Forms.Label lblDateCreate;
        private System.Windows.Forms.DateTimePicker dtmDateCreate;
        private System.Windows.Forms.DateTimePicker dtmDateFinish;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitleNull;
        private System.Windows.Forms.Label lblDesNull;
        private System.Windows.Forms.Label lblFinishdateEarlier;
        private System.Windows.Forms.Label label1;
    }
}