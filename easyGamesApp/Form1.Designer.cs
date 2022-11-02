
namespace easyGamesApp
{
    partial class Form1
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
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.edtComment = new System.Windows.Forms.TextBox();
            this.edtAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.edtCom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(202, 55);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(166, 21);
            this.cmbClient.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(246, 104);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 24);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View ";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lstData
            // 
            this.lstData.HideSelection = false;
            this.lstData.Location = new System.Drawing.Point(106, 144);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(384, 123);
            this.lstData.TabIndex = 2;
            this.lstData.UseCompatibleStateImageBehavior = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(380, 282);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit comment";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // edtComment
            // 
            this.edtComment.Enabled = false;
            this.edtComment.Location = new System.Drawing.Point(224, 285);
            this.edtComment.Name = "edtComment";
            this.edtComment.Size = new System.Drawing.Size(125, 20);
            this.edtComment.TabIndex = 4;
            // 
            // edtAmount
            // 
            this.edtAmount.Enabled = false;
            this.edtAmount.Location = new System.Drawing.Point(224, 335);
            this.edtAmount.Name = "edtAmount";
            this.edtAmount.Size = new System.Drawing.Size(125, 20);
            this.edtAmount.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(291, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // edtCom
            // 
            this.edtCom.Enabled = false;
            this.edtCom.Location = new System.Drawing.Point(224, 387);
            this.edtCom.Name = "edtCom";
            this.edtCom.Size = new System.Drawing.Size(125, 20);
            this.edtCom.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Transaction Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Comment";
            // 
            // cmbTrans
            // 
            this.cmbTrans.Enabled = false;
            this.cmbTrans.FormattingEnabled = true;
            this.cmbTrans.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.cmbTrans.Location = new System.Drawing.Point(224, 361);
            this.cmbTrans.Name = "cmbTrans";
            this.cmbTrans.Size = new System.Drawing.Size(125, 21);
            this.cmbTrans.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Comment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtCom);
            this.Controls.Add(this.edtAmount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.edtComment);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.cmbClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListView lstData;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox edtComment;
        private System.Windows.Forms.TextBox edtAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox edtCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

