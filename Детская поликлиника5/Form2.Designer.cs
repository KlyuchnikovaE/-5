namespace Детская_поликлиника5
{
    partial class Form2
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
            System.Windows.Forms.Label код_анализаLabel;
            System.Windows.Forms.Label код_пациентаLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label датаLabel;
            this.детская_поликлиника_1DataSet = new Детская_поликлиника5.Детская_поликлиника_1DataSet();
            this.анализыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.анализыTableAdapter = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.АнализыTableAdapter();
            this.tableAdapterManager = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager();
            this.код_анализаTextBox = new System.Windows.Forms.TextBox();
            this.код_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            код_анализаLabel = new System.Windows.Forms.Label();
            код_пациентаLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.анализыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // детская_поликлиника_1DataSet
            // 
            this.детская_поликлиника_1DataSet.DataSetName = "Детская_поликлиника_1DataSet";
            this.детская_поликлиника_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // анализыBindingSource
            // 
            this.анализыBindingSource.DataMember = "Анализы";
            this.анализыBindingSource.DataSource = this.детская_поликлиника_1DataSet;
            // 
            // анализыTableAdapter
            // 
            this.анализыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АнализыTableAdapter = this.анализыTableAdapter;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = null;
            this.tableAdapterManager.ПриёмTableAdapter = null;
            this.tableAdapterManager.ПроцедурыTableAdapter = null;
            // 
            // код_анализаLabel
            // 
            код_анализаLabel.AutoSize = true;
            код_анализаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_анализаLabel.Location = new System.Drawing.Point(90, 74);
            код_анализаLabel.Name = "код_анализаLabel";
            код_анализаLabel.Size = new System.Drawing.Size(94, 16);
            код_анализаLabel.TabIndex = 1;
            код_анализаLabel.Text = "Код анализа:";
            // 
            // код_анализаTextBox
            // 
            this.код_анализаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.анализыBindingSource, "Код анализа", true));
            this.код_анализаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_анализаTextBox.Location = new System.Drawing.Point(205, 71);
            this.код_анализаTextBox.Name = "код_анализаTextBox";
            this.код_анализаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_анализаTextBox.TabIndex = 2;
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_пациентаLabel.Location = new System.Drawing.Point(90, 100);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(101, 16);
            код_пациентаLabel.TabIndex = 3;
            код_пациентаLabel.Text = "Код пациента:";
            // 
            // код_пациентаTextBox
            // 
            this.код_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.анализыBindingSource, "Код пациента", true));
            this.код_пациентаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_пациентаTextBox.Location = new System.Drawing.Point(205, 97);
            this.код_пациентаTextBox.Name = "код_пациентаTextBox";
            this.код_пациентаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_пациентаTextBox.TabIndex = 4;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименованиеLabel.Location = new System.Drawing.Point(90, 126);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(110, 16);
            наименованиеLabel.TabIndex = 5;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.анализыBindingSource, "Наименование", true));
            this.наименованиеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименованиеTextBox.Location = new System.Drawing.Point(205, 123);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(200, 22);
            this.наименованиеTextBox.TabIndex = 6;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(90, 153);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(43, 16);
            датаLabel.TabIndex = 7;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.анализыBindingSource, "Дата", true));
            this.датаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаDateTimePicker.Location = new System.Drawing.Point(205, 148);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаDateTimePicker.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(252, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_анализаLabel);
            this.Controls.Add(this.код_анализаTextBox);
            this.Controls.Add(код_пациентаLabel);
            this.Controls.Add(this.код_пациентаTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Name = "Form2";
            this.Text = "Детская поликлиника";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.анализыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Детская_поликлиника_1DataSet детская_поликлиника_1DataSet;
        private System.Windows.Forms.BindingSource анализыBindingSource;
        private Детская_поликлиника_1DataSetTableAdapters.АнализыTableAdapter анализыTableAdapter;
        private Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_анализаTextBox;
        private System.Windows.Forms.TextBox код_пациентаTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}