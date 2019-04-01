namespace Детская_поликлиника5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_приёмаLabel;
            System.Windows.Forms.Label код_врачаLabel;
            System.Windows.Forms.Label код_пациентаLabel;
            System.Windows.Forms.Label температураLabel;
            System.Windows.Forms.Label давлениеLabel;
            System.Windows.Forms.Label диагнозLabel;
            this.детская_поликлиника_1DataSet = new Детская_поликлиника5.Детская_поликлиника_1DataSet();
            this.приёмBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приёмTableAdapter = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.ПриёмTableAdapter();
            this.tableAdapterManager = new Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager();
            this.код_приёмаTextBox = new System.Windows.Forms.TextBox();
            this.код_врачаTextBox = new System.Windows.Forms.TextBox();
            this.код_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.температураTextBox = new System.Windows.Forms.TextBox();
            this.давлениеTextBox = new System.Windows.Forms.TextBox();
            this.диагнозTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            код_приёмаLabel = new System.Windows.Forms.Label();
            код_врачаLabel = new System.Windows.Forms.Label();
            код_пациентаLabel = new System.Windows.Forms.Label();
            температураLabel = new System.Windows.Forms.Label();
            давлениеLabel = new System.Windows.Forms.Label();
            диагнозLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приёмBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_приёмаLabel
            // 
            код_приёмаLabel.AutoSize = true;
            код_приёмаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_приёмаLabel.Location = new System.Drawing.Point(68, 67);
            код_приёмаLabel.Name = "код_приёмаLabel";
            код_приёмаLabel.Size = new System.Drawing.Size(87, 16);
            код_приёмаLabel.TabIndex = 1;
            код_приёмаLabel.Text = "Код приёма:";
            // 
            // код_врачаLabel
            // 
            код_врачаLabel.AutoSize = true;
            код_врачаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_врачаLabel.Location = new System.Drawing.Point(68, 93);
            код_врачаLabel.Name = "код_врачаLabel";
            код_врачаLabel.Size = new System.Drawing.Size(78, 16);
            код_врачаLabel.TabIndex = 3;
            код_врачаLabel.Text = "Код врача:";
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_пациентаLabel.Location = new System.Drawing.Point(68, 119);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(101, 16);
            код_пациентаLabel.TabIndex = 5;
            код_пациентаLabel.Text = "Код пациента:";
            // 
            // температураLabel
            // 
            температураLabel.AutoSize = true;
            температураLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            температураLabel.Location = new System.Drawing.Point(68, 145);
            температураLabel.Name = "температураLabel";
            температураLabel.Size = new System.Drawing.Size(100, 16);
            температураLabel.TabIndex = 7;
            температураLabel.Text = "Температура:";
            // 
            // давлениеLabel
            // 
            давлениеLabel.AutoSize = true;
            давлениеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            давлениеLabel.Location = new System.Drawing.Point(68, 171);
            давлениеLabel.Name = "давлениеLabel";
            давлениеLabel.Size = new System.Drawing.Size(76, 16);
            давлениеLabel.TabIndex = 9;
            давлениеLabel.Text = "Давление:";
            // 
            // диагнозLabel
            // 
            диагнозLabel.AutoSize = true;
            диагнозLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            диагнозLabel.Location = new System.Drawing.Point(68, 197);
            диагнозLabel.Name = "диагнозLabel";
            диагнозLabel.Size = new System.Drawing.Size(66, 16);
            диагнозLabel.TabIndex = 11;
            диагнозLabel.Text = "Диагноз:";
            // 
            // детская_поликлиника_1DataSet
            // 
            this.детская_поликлиника_1DataSet.DataSetName = "Детская_поликлиника_1DataSet";
            this.детская_поликлиника_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // приёмBindingSource
            // 
            this.приёмBindingSource.DataMember = "Приём";
            this.приёмBindingSource.DataSource = this.детская_поликлиника_1DataSet;
            // 
            // приёмTableAdapter
            // 
            this.приёмTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Детская_поликлиника5.Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АнализыTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = null;
            this.tableAdapterManager.ПриёмTableAdapter = this.приёмTableAdapter;
            this.tableAdapterManager.ПроцедурыTableAdapter = null;
            // 
            // код_приёмаTextBox
            // 
            this.код_приёмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Код приёма", true));
            this.код_приёмаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_приёмаTextBox.Location = new System.Drawing.Point(175, 64);
            this.код_приёмаTextBox.Name = "код_приёмаTextBox";
            this.код_приёмаTextBox.Size = new System.Drawing.Size(206, 22);
            this.код_приёмаTextBox.TabIndex = 2;
            // 
            // код_врачаTextBox
            // 
            this.код_врачаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Код врача", true));
            this.код_врачаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_врачаTextBox.Location = new System.Drawing.Point(175, 90);
            this.код_врачаTextBox.Name = "код_врачаTextBox";
            this.код_врачаTextBox.Size = new System.Drawing.Size(206, 22);
            this.код_врачаTextBox.TabIndex = 4;
            // 
            // код_пациентаTextBox
            // 
            this.код_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Код пациента", true));
            this.код_пациентаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_пациентаTextBox.Location = new System.Drawing.Point(174, 116);
            this.код_пациентаTextBox.Name = "код_пациентаTextBox";
            this.код_пациентаTextBox.Size = new System.Drawing.Size(206, 22);
            this.код_пациентаTextBox.TabIndex = 6;
            // 
            // температураTextBox
            // 
            this.температураTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Температура", true));
            this.температураTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.температураTextBox.Location = new System.Drawing.Point(175, 142);
            this.температураTextBox.Name = "температураTextBox";
            this.температураTextBox.Size = new System.Drawing.Size(206, 22);
            this.температураTextBox.TabIndex = 8;
            // 
            // давлениеTextBox
            // 
            this.давлениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Давление", true));
            this.давлениеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.давлениеTextBox.Location = new System.Drawing.Point(174, 168);
            this.давлениеTextBox.Name = "давлениеTextBox";
            this.давлениеTextBox.Size = new System.Drawing.Size(206, 22);
            this.давлениеTextBox.TabIndex = 10;
            // 
            // диагнозTextBox
            // 
            this.диагнозTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.приёмBindingSource, "Диагноз", true));
            this.диагнозTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.диагнозTextBox.Location = new System.Drawing.Point(174, 194);
            this.диагнозTextBox.Name = "диагнозTextBox";
            this.диагнозTextBox.Size = new System.Drawing.Size(206, 22);
            this.диагнозTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(216, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(621, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 46);
            this.button4.TabIndex = 16;
            this.button4.Text = "Пациенты";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(621, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 50);
            this.button5.TabIndex = 17;
            this.button5.Text = "Процедуры";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(621, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "Врачи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(621, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "Анализы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_приёмаLabel);
            this.Controls.Add(this.код_приёмаTextBox);
            this.Controls.Add(код_врачаLabel);
            this.Controls.Add(this.код_врачаTextBox);
            this.Controls.Add(код_пациентаLabel);
            this.Controls.Add(this.код_пациентаTextBox);
            this.Controls.Add(температураLabel);
            this.Controls.Add(this.температураTextBox);
            this.Controls.Add(давлениеLabel);
            this.Controls.Add(this.давлениеTextBox);
            this.Controls.Add(диагнозLabel);
            this.Controls.Add(this.диагнозTextBox);
            this.Name = "Form1";
            this.Text = "Детская поликлиника";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.детская_поликлиника_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приёмBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Детская_поликлиника_1DataSet детская_поликлиника_1DataSet;
        private System.Windows.Forms.BindingSource приёмBindingSource;
        private Детская_поликлиника_1DataSetTableAdapters.ПриёмTableAdapter приёмTableAdapter;
        private Детская_поликлиника_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_приёмаTextBox;
        private System.Windows.Forms.TextBox код_врачаTextBox;
        private System.Windows.Forms.TextBox код_пациентаTextBox;
        private System.Windows.Forms.TextBox температураTextBox;
        private System.Windows.Forms.TextBox давлениеTextBox;
        private System.Windows.Forms.TextBox диагнозTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

