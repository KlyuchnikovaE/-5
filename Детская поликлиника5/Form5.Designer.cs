namespace Детская_поликлиника5
{
    partial class Form5
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
            System.Windows.Forms.Label код_процедурLabel;
            System.Windows.Forms.Label код_пациентаLabel;
            System.Windows.Forms.Label наименование_процедурыLabel;
            System.Windows.Forms.Label описание_процедурыLabel;
            System.Windows.Forms.Label датаLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.детская_поликлиника_1DataSet = new Детская_поликлиника5.Детская_поликлиника_1DataSet();
            this.процедурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедурыTableAdapter = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.ПроцедурыTableAdapter();
            this.tableAdapterManager = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager();
            this.код_процедурTextBox = new System.Windows.Forms.TextBox();
            this.код_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.наименование_процедурыTextBox = new System.Windows.Forms.TextBox();
            this.описание_процедурыTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            код_процедурLabel = new System.Windows.Forms.Label();
            код_пациентаLabel = new System.Windows.Forms.Label();
            наименование_процедурыLabel = new System.Windows.Forms.Label();
            описание_процедурыLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедурыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(309, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // детская_поликлиника_1DataSet
            // 
            this.детская_поликлиника_1DataSet.DataSetName = "Детская_поликлиника_1DataSet";
            this.детская_поликлиника_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // процедурыBindingSource
            // 
            this.процедурыBindingSource.DataMember = "Процедуры";
            this.процедурыBindingSource.DataSource = this.детская_поликлиника_1DataSet;
            // 
            // процедурыTableAdapter
            // 
            this.процедурыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АнализыTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = null;
            this.tableAdapterManager.ПриёмTableAdapter = null;
            this.tableAdapterManager.ПроцедурыTableAdapter = this.процедурыTableAdapter;
            // 
            // код_процедурLabel
            // 
            код_процедурLabel.AutoSize = true;
            код_процедурLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_процедурLabel.Location = new System.Drawing.Point(67, 93);
            код_процедурLabel.Name = "код_процедурLabel";
            код_процедурLabel.Size = new System.Drawing.Size(102, 16);
            код_процедурLabel.TabIndex = 2;
            код_процедурLabel.Text = "Код процедур:";
            // 
            // код_процедурTextBox
            // 
            this.код_процедурTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедурыBindingSource, "Код процедур", true));
            this.код_процедурTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_процедурTextBox.Location = new System.Drawing.Point(259, 90);
            this.код_процедурTextBox.Name = "код_процедурTextBox";
            this.код_процедурTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_процедурTextBox.TabIndex = 3;
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_пациентаLabel.Location = new System.Drawing.Point(67, 119);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(101, 16);
            код_пациентаLabel.TabIndex = 4;
            код_пациентаLabel.Text = "Код пациента:";
            // 
            // код_пациентаTextBox
            // 
            this.код_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедурыBindingSource, "Код пациента", true));
            this.код_пациентаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_пациентаTextBox.Location = new System.Drawing.Point(259, 116);
            this.код_пациентаTextBox.Name = "код_пациентаTextBox";
            this.код_пациентаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_пациентаTextBox.TabIndex = 5;
            // 
            // наименование_процедурыLabel
            // 
            наименование_процедурыLabel.AutoSize = true;
            наименование_процедурыLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименование_процедурыLabel.Location = new System.Drawing.Point(67, 145);
            наименование_процедурыLabel.Name = "наименование_процедурыLabel";
            наименование_процедурыLabel.Size = new System.Drawing.Size(186, 16);
            наименование_процедурыLabel.TabIndex = 6;
            наименование_процедурыLabel.Text = "Наименование процедуры:";
            // 
            // наименование_процедурыTextBox
            // 
            this.наименование_процедурыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедурыBindingSource, "Наименование процедуры", true));
            this.наименование_процедурыTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименование_процедурыTextBox.Location = new System.Drawing.Point(259, 142);
            this.наименование_процедурыTextBox.Name = "наименование_процедурыTextBox";
            this.наименование_процедурыTextBox.Size = new System.Drawing.Size(200, 22);
            this.наименование_процедурыTextBox.TabIndex = 7;
            // 
            // описание_процедурыLabel
            // 
            описание_процедурыLabel.AutoSize = true;
            описание_процедурыLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            описание_процедурыLabel.Location = new System.Drawing.Point(67, 171);
            описание_процедурыLabel.Name = "описание_процедурыLabel";
            описание_процедурыLabel.Size = new System.Drawing.Size(152, 16);
            описание_процедурыLabel.TabIndex = 8;
            описание_процедурыLabel.Text = "Описание процедуры:";
            // 
            // описание_процедурыTextBox
            // 
            this.описание_процедурыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедурыBindingSource, "Описание процедуры", true));
            this.описание_процедурыTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.описание_процедурыTextBox.Location = new System.Drawing.Point(259, 168);
            this.описание_процедурыTextBox.Name = "описание_процедурыTextBox";
            this.описание_процедурыTextBox.Size = new System.Drawing.Size(200, 22);
            this.описание_процедурыTextBox.TabIndex = 9;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(67, 198);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(43, 16);
            датаLabel.TabIndex = 10;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.процедурыBindingSource, "Дата", true));
            this.датаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаDateTimePicker.Location = new System.Drawing.Point(259, 193);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаDateTimePicker.TabIndex = 11;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(код_процедурLabel);
            this.Controls.Add(this.код_процедурTextBox);
            this.Controls.Add(код_пациентаLabel);
            this.Controls.Add(this.код_пациентаTextBox);
            this.Controls.Add(наименование_процедурыLabel);
            this.Controls.Add(this.наименование_процедурыTextBox);
            this.Controls.Add(описание_процедурыLabel);
            this.Controls.Add(this.описание_процедурыTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Детская поликлиника";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедурыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Детская_поликлиника_1DataSet детская_поликлиника_1DataSet;
        private System.Windows.Forms.BindingSource процедурыBindingSource;
        private Детская_поликлиника_1DataSetTableAdapters.ПроцедурыTableAdapter процедурыTableAdapter;
        private Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_процедурTextBox;
        private System.Windows.Forms.TextBox код_пациентаTextBox;
        private System.Windows.Forms.TextBox наименование_процедурыTextBox;
        private System.Windows.Forms.TextBox описание_процедурыTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
    }
}