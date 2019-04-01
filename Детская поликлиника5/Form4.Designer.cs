namespace Детская_поликлиника5
{
    partial class Form4
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
            System.Windows.Forms.Label код_пациентаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label сНИЛСLabel;
            System.Windows.Forms.Label страховой_полисLabel;
            this.детская_поликлиника_1DataSet = new Детская_поликлиника5.Детская_поликлиника_1DataSet();
            this.пациентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентыTableAdapter = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.ПациентыTableAdapter();
            this.tableAdapterManager = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager();
            this.код_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.сНИЛСTextBox = new System.Windows.Forms.TextBox();
            this.страховой_полисTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            код_пациентаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            сНИЛСLabel = new System.Windows.Forms.Label();
            страховой_полисLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // детская_поликлиника_1DataSet
            // 
            this.детская_поликлиника_1DataSet.DataSetName = "Детская_поликлиника_1DataSet";
            this.детская_поликлиника_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пациентыBindingSource
            // 
            this.пациентыBindingSource.DataMember = "Пациенты";
            this.пациентыBindingSource.DataSource = this.детская_поликлиника_1DataSet;
            // 
            // пациентыTableAdapter
            // 
            this.пациентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АнализыTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = this.пациентыTableAdapter;
            this.tableAdapterManager.ПриёмTableAdapter = null;
            this.tableAdapterManager.ПроцедурыTableAdapter = null;
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_пациентаLabel.Location = new System.Drawing.Point(92, 61);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(101, 16);
            код_пациентаLabel.TabIndex = 1;
            код_пациентаLabel.Text = "Код пациента:";
            // 
            // код_пациентаTextBox
            // 
            this.код_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Код пациента", true));
            this.код_пациентаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_пациентаTextBox.Location = new System.Drawing.Point(221, 58);
            this.код_пациентаTextBox.Name = "код_пациентаTextBox";
            this.код_пациентаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_пациентаTextBox.TabIndex = 2;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фамилияLabel.Location = new System.Drawing.Point(92, 87);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(70, 16);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Фамилия", true));
            this.фамилияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фамилияTextBox.Location = new System.Drawing.Point(221, 84);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 22);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            имяLabel.Location = new System.Drawing.Point(92, 113);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(37, 16);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Имя", true));
            this.имяTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.имяTextBox.Location = new System.Drawing.Point(221, 110);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 22);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            отчествоLabel.Location = new System.Drawing.Point(92, 139);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(74, 16);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Отчество", true));
            this.отчествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчествоTextBox.Location = new System.Drawing.Point(221, 136);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 22);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_рожденияLabel.Location = new System.Drawing.Point(92, 166);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(110, 16);
            дата_рожденияLabel.TabIndex = 9;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.пациентыBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(221, 161);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_рожденияDateTimePicker.TabIndex = 10;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            полLabel.Location = new System.Drawing.Point(92, 191);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(37, 16);
            полLabel.TabIndex = 11;
            полLabel.Text = "Пол:";
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Пол", true));
            this.полTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.полTextBox.Location = new System.Drawing.Point(221, 188);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(200, 22);
            this.полTextBox.TabIndex = 12;
            // 
            // сНИЛСLabel
            // 
            сНИЛСLabel.AutoSize = true;
            сНИЛСLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            сНИЛСLabel.Location = new System.Drawing.Point(92, 217);
            сНИЛСLabel.Name = "сНИЛСLabel";
            сНИЛСLabel.Size = new System.Drawing.Size(58, 16);
            сНИЛСLabel.TabIndex = 13;
            сНИЛСLabel.Text = "СНИЛС:";
            // 
            // сНИЛСTextBox
            // 
            this.сНИЛСTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "СНИЛС", true));
            this.сНИЛСTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сНИЛСTextBox.Location = new System.Drawing.Point(221, 214);
            this.сНИЛСTextBox.Name = "сНИЛСTextBox";
            this.сНИЛСTextBox.Size = new System.Drawing.Size(200, 22);
            this.сНИЛСTextBox.TabIndex = 14;
            // 
            // страховой_полисLabel
            // 
            страховой_полисLabel.AutoSize = true;
            страховой_полисLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            страховой_полисLabel.Location = new System.Drawing.Point(92, 243);
            страховой_полисLabel.Name = "страховой_полисLabel";
            страховой_полисLabel.Size = new System.Drawing.Size(123, 16);
            страховой_полисLabel.TabIndex = 15;
            страховой_полисLabel.Text = "Страховой полис:";
            // 
            // страховой_полисTextBox
            // 
            this.страховой_полисTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Страховой полис", true));
            this.страховой_полисTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.страховой_полисTextBox.Location = new System.Drawing.Point(221, 240);
            this.страховой_полисTextBox.Name = "страховой_полисTextBox";
            this.страховой_полисTextBox.Size = new System.Drawing.Size(200, 22);
            this.страховой_полисTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(267, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_пациентаLabel);
            this.Controls.Add(this.код_пациентаTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(сНИЛСLabel);
            this.Controls.Add(this.сНИЛСTextBox);
            this.Controls.Add(страховой_полисLabel);
            this.Controls.Add(this.страховой_полисTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form4";
            this.Text = "Детская поликлиника";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Детская_поликлиника_1DataSet детская_поликлиника_1DataSet;
        private System.Windows.Forms.BindingSource пациентыBindingSource;
        private Детская_поликлиника_1DataSetTableAdapters.ПациентыTableAdapter пациентыTableAdapter;
        private Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_пациентаTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox сНИЛСTextBox;
        private System.Windows.Forms.TextBox страховой_полисTextBox;
        private System.Windows.Forms.Button button1;
    }
}