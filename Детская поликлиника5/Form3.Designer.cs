namespace Детская_поликлиника5
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_врачаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label специальностьLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.детская_поликлиника_1DataSet = new Детская_поликлиника5.Детская_поликлиника_1DataSet();
            this.врачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.врачиTableAdapter = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.ВрачиTableAdapter();
            this.tableAdapterManager = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager();
            this.код_врачаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.специальностьTextBox = new System.Windows.Forms.TextBox();
            код_врачаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            специальностьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(272, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // детская_поликлиника_1DataSet
            // 
            this.детская_поликлиника_1DataSet.DataSetName = "Детская_поликлиника_1DataSet";
            this.детская_поликлиника_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // врачиBindingSource
            // 
            this.врачиBindingSource.DataMember = "Врачи";
            this.врачиBindingSource.DataSource = this.детская_поликлиника_1DataSet;
            // 
            // врачиTableAdapter
            // 
            this.врачиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АнализыTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = this.врачиTableAdapter;
            this.tableAdapterManager.ПациентыTableAdapter = null;
            this.tableAdapterManager.ПриёмTableAdapter = null;
            this.tableAdapterManager.ПроцедурыTableAdapter = null;
            // 
            // код_врачаLabel
            // 
            код_врачаLabel.AutoSize = true;
            код_врачаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_врачаLabel.Location = new System.Drawing.Point(113, 102);
            код_врачаLabel.Name = "код_врачаLabel";
            код_врачаLabel.Size = new System.Drawing.Size(78, 16);
            код_врачаLabel.TabIndex = 2;
            код_врачаLabel.Text = "Код врача:";
            // 
            // код_врачаTextBox
            // 
            this.код_врачаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Код врача", true));
            this.код_врачаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_врачаTextBox.Location = new System.Drawing.Point(231, 99);
            this.код_врачаTextBox.Name = "код_врачаTextBox";
            this.код_врачаTextBox.Size = new System.Drawing.Size(174, 22);
            this.код_врачаTextBox.TabIndex = 3;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фамилияLabel.Location = new System.Drawing.Point(113, 128);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(70, 16);
            фамилияLabel.TabIndex = 4;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Фамилия", true));
            this.фамилияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фамилияTextBox.Location = new System.Drawing.Point(231, 125);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(174, 22);
            this.фамилияTextBox.TabIndex = 5;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            имяLabel.Location = new System.Drawing.Point(113, 154);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(37, 16);
            имяLabel.TabIndex = 6;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Имя", true));
            this.имяTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.имяTextBox.Location = new System.Drawing.Point(231, 151);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(174, 22);
            this.имяTextBox.TabIndex = 7;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            отчествоLabel.Location = new System.Drawing.Point(113, 180);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(74, 16);
            отчествоLabel.TabIndex = 8;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Отчество", true));
            this.отчествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчествоTextBox.Location = new System.Drawing.Point(231, 177);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(174, 22);
            this.отчествоTextBox.TabIndex = 9;
            // 
            // специальностьLabel
            // 
            специальностьLabel.AutoSize = true;
            специальностьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            специальностьLabel.Location = new System.Drawing.Point(113, 206);
            специальностьLabel.Name = "специальностьLabel";
            специальностьLabel.Size = new System.Drawing.Size(112, 16);
            специальностьLabel.TabIndex = 10;
            специальностьLabel.Text = "Специальность:";
            // 
            // специальностьTextBox
            // 
            this.специальностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.врачиBindingSource, "Специальность", true));
            this.специальностьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.специальностьTextBox.Location = new System.Drawing.Point(231, 205);
            this.специальностьTextBox.Name = "специальностьTextBox";
            this.специальностьTextBox.Size = new System.Drawing.Size(174, 22);
            this.специальностьTextBox.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(код_врачаLabel);
            this.Controls.Add(this.код_врачаTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(специальностьLabel);
            this.Controls.Add(this.специальностьTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Детская поликлиника";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Детская_поликлиника_1DataSet детская_поликлиника_1DataSet;
        private System.Windows.Forms.BindingSource врачиBindingSource;
        private Детская_поликлиника_1DataSetTableAdapters.ВрачиTableAdapter врачиTableAdapter;
        private Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_врачаTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox специальностьTextBox;
    }
}