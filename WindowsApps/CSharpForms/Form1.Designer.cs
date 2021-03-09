
namespace CSharpForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.bListDlls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello yolo";
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(264, 263);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(144, 41);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(16, 44);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(391, 203);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            this.rtbLog.WordWrap = false;
            // 
            // bListDlls
            // 
            this.bListDlls.Location = new System.Drawing.Point(16, 263);
            this.bListDlls.Name = "bListDlls";
            this.bListDlls.Size = new System.Drawing.Size(142, 41);
            this.bListDlls.TabIndex = 3;
            this.bListDlls.Text = "List Dlls";
            this.bListDlls.UseVisualStyleBackColor = true;
            this.bListDlls.Click += new System.EventHandler(this.bListDlls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 316);
            this.Controls.Add(this.bListDlls);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button bListDlls;
    }
}

