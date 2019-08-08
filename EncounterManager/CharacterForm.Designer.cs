namespace EncounterManager
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.components = new System.ComponentModel.Container();
            this._iniBonusBox = new System.Windows.Forms.TextBox();
            this._hpBox = new System.Windows.Forms.TextBox();
            this._nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._saveBtn = new System.Windows.Forms.Button();
            this._cancelBtn = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _iniBonusBox
            // 
            this._iniBonusBox.Location = new System.Drawing.Point(128, 40);
            this._iniBonusBox.MaxLength = 3;
            this._iniBonusBox.Name = "_iniBonusBox";
            this._iniBonusBox.Size = new System.Drawing.Size(100, 22);
            this._iniBonusBox.TabIndex = 1;
            this._iniBonusBox.Validating += new System.ComponentModel.CancelEventHandler(this._iniBonusBox_Validating);
            // 
            // _hpBox
            // 
            this._hpBox.Location = new System.Drawing.Point(128, 68);
            this._hpBox.MaxLength = 4;
            this._hpBox.Name = "_hpBox";
            this._hpBox.Size = new System.Drawing.Size(100, 22);
            this._hpBox.TabIndex = 2;
            this._hpBox.Validating += new System.ComponentModel.CancelEventHandler(this._hpBox_Validating);
            // 
            // _nameBox
            // 
            this._nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._nameBox.Location = new System.Drawing.Point(128, 12);
            this._nameBox.MaxLength = 30;
            this._nameBox.Name = "_nameBox";
            this._nameBox.Size = new System.Drawing.Size(187, 22);
            this._nameBox.TabIndex = 0;
            this._nameBox.Validating += new System.ComponentModel.CancelEventHandler(this._nameBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Initiative Bonus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hit Points";
            // 
            // _saveBtn
            // 
            this._saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._saveBtn.Location = new System.Drawing.Point(15, 113);
            this._saveBtn.Name = "_saveBtn";
            this._saveBtn.Size = new System.Drawing.Size(75, 23);
            this._saveBtn.TabIndex = 6;
            this._saveBtn.Text = "Save";
            this._saveBtn.UseVisualStyleBackColor = true;
            this._saveBtn.Click += new System.EventHandler(this.OnSave);
            // 
            // _cancelBtn
            // 
            this._cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelBtn.CausesValidation = false;
            this._cancelBtn.Location = new System.Drawing.Point(314, 113);
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.Size = new System.Drawing.Size(75, 23);
            this._cancelBtn.TabIndex = 7;
            this._cancelBtn.Text = "Cancel";
            this._cancelBtn.UseVisualStyleBackColor = true;
            this._cancelBtn.Click += new System.EventHandler(this._cancelBtn_Click);
            // 
            // _errorProvider
            // 
            this._errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errorProvider.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 148);
            this.Controls.Add(this._cancelBtn);
            this.Controls.Add(this._saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._nameBox);
            this.Controls.Add(this._hpBox);
            this.Controls.Add(this._iniBonusBox);
            this.Name = "CharacterForm";
            this.Text = "Character";
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _iniBonusBox;
        private System.Windows.Forms.TextBox _hpBox;
        private System.Windows.Forms.TextBox _nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _saveBtn;
        private System.Windows.Forms.Button _cancelBtn;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}