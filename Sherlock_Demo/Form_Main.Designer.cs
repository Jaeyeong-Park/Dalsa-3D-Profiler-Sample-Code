namespace Sherlock_Demo
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Terminate = new System.Windows.Forms.Button();
            this.btn_Halt = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Initialize = new System.Windows.Forms.Button();
            this.btn_FileLoad = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Result = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Distance = new System.Windows.Forms.TextBox();
            this.textBox_highHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_BottomHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.axAxIpeDisplay_3DCloud = new AxipedisplayctrlLib.AxAxIpeDisplay();
            this.axAxIpeDisplay_Mono16 = new AxipedisplayctrlLib.AxAxIpeDisplay();
            this.axAxIpeDisplay_Mono8 = new AxipedisplayctrlLib.AxAxIpeDisplay();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxIpeDisplay_3DCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxIpeDisplay_Mono16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxIpeDisplay_Mono8)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1664, 543);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Terminate, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_Halt, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_Run, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_Initialize, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_FileLoad, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_Status, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 543);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_Terminate
            // 
            this.btn_Terminate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Terminate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Terminate.Location = new System.Drawing.Point(1, 441);
            this.btn_Terminate.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Terminate.Name = "btn_Terminate";
            this.btn_Terminate.Size = new System.Drawing.Size(198, 101);
            this.btn_Terminate.TabIndex = 4;
            this.btn_Terminate.Text = "Terminate";
            this.btn_Terminate.UseVisualStyleBackColor = true;
            this.btn_Terminate.Click += new System.EventHandler(this.btn_Terminate_Click);
            // 
            // btn_Halt
            // 
            this.btn_Halt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Halt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Halt.Location = new System.Drawing.Point(1, 341);
            this.btn_Halt.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Halt.Name = "btn_Halt";
            this.btn_Halt.Size = new System.Drawing.Size(198, 98);
            this.btn_Halt.TabIndex = 3;
            this.btn_Halt.Text = "Halt";
            this.btn_Halt.UseVisualStyleBackColor = true;
            this.btn_Halt.Click += new System.EventHandler(this.btn_Halt_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Run.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(1, 241);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(198, 98);
            this.btn_Run.TabIndex = 2;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Initialize
            // 
            this.btn_Initialize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Initialize.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Initialize.Location = new System.Drawing.Point(1, 141);
            this.btn_Initialize.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Initialize.Name = "btn_Initialize";
            this.btn_Initialize.Size = new System.Drawing.Size(198, 98);
            this.btn_Initialize.TabIndex = 1;
            this.btn_Initialize.Text = "Initialize";
            this.btn_Initialize.UseVisualStyleBackColor = true;
            this.btn_Initialize.Click += new System.EventHandler(this.btn_Initialize_Click);
            // 
            // btn_FileLoad
            // 
            this.btn_FileLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FileLoad.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FileLoad.Location = new System.Drawing.Point(1, 41);
            this.btn_FileLoad.Margin = new System.Windows.Forms.Padding(1);
            this.btn_FileLoad.Name = "btn_FileLoad";
            this.btn_FileLoad.Size = new System.Drawing.Size(198, 98);
            this.btn_FileLoad.TabIndex = 0;
            this.btn_FileLoad.Text = "File Load";
            this.btn_FileLoad.UseVisualStyleBackColor = true;
            this.btn_FileLoad.Click += new System.EventHandler(this.btn_FileLoad_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Status.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(3, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(194, 40);
            this.label_Status.TabIndex = 5;
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1664, 693);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label_Result, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 543);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1664, 150);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.Silver;
            this.label_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Result.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.ForeColor = System.Drawing.Color.Black;
            this.label_Result.Location = new System.Drawing.Point(1, 1);
            this.label_Result.Margin = new System.Windows.Forms.Padding(1);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(198, 148);
            this.label_Result.TabIndex = 0;
            this.label_Result.Text = "Result";
            this.label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 861F));
            this.tableLayoutPanel6.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.textBox_Distance, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.textBox_highHeight, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox_BottomHeight, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1464, 150);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(606, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(855, 50);
            this.label9.TabIndex = 10;
            this.label9.Text = "um";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(606, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(855, 50);
            this.label8.TabIndex = 9;
            this.label8.Text = "um";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Distance
            // 
            this.textBox_Distance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Distance.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Distance.Location = new System.Drawing.Point(288, 110);
            this.textBox_Distance.Name = "textBox_Distance";
            this.textBox_Distance.ReadOnly = true;
            this.textBox_Distance.Size = new System.Drawing.Size(312, 30);
            this.textBox_Distance.TabIndex = 7;
            // 
            // textBox_highHeight
            // 
            this.textBox_highHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_highHeight.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_highHeight.Location = new System.Drawing.Point(288, 60);
            this.textBox_highHeight.Name = "textBox_highHeight";
            this.textBox_highHeight.ReadOnly = true;
            this.textBox_highHeight.Size = new System.Drawing.Size(312, 30);
            this.textBox_highHeight.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 48);
            this.label6.TabIndex = 4;
            this.label6.Text = "Distance";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 48);
            this.label5.TabIndex = 2;
            this.label5.Text = "Top Height";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 48);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bottom Height";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_BottomHeight
            // 
            this.textBox_BottomHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_BottomHeight.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BottomHeight.Location = new System.Drawing.Point(288, 10);
            this.textBox_BottomHeight.Name = "textBox_BottomHeight";
            this.textBox_BottomHeight.ReadOnly = true;
            this.textBox_BottomHeight.Size = new System.Drawing.Size(312, 30);
            this.textBox_BottomHeight.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(855, 50);
            this.label7.TabIndex = 8;
            this.label7.Text = "um";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.axAxIpeDisplay_3DCloud, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.axAxIpeDisplay_Mono16, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.axAxIpeDisplay_Mono8, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1464, 543);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display - 3D Cloud";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(488, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display - Mono 16";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(975, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Display - Mono 8";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axAxIpeDisplay_3DCloud
            // 
            this.axAxIpeDisplay_3DCloud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAxIpeDisplay_3DCloud.Enabled = true;
            this.axAxIpeDisplay_3DCloud.Location = new System.Drawing.Point(3, 43);
            this.axAxIpeDisplay_3DCloud.Name = "axAxIpeDisplay_3DCloud";
            this.axAxIpeDisplay_3DCloud.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxIpeDisplay_3DCloud.OcxState")));
            this.axAxIpeDisplay_3DCloud.Size = new System.Drawing.Size(481, 497);
            this.axAxIpeDisplay_3DCloud.TabIndex = 3;
            // 
            // axAxIpeDisplay_Mono16
            // 
            this.axAxIpeDisplay_Mono16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAxIpeDisplay_Mono16.Enabled = true;
            this.axAxIpeDisplay_Mono16.Location = new System.Drawing.Point(490, 43);
            this.axAxIpeDisplay_Mono16.Name = "axAxIpeDisplay_Mono16";
            this.axAxIpeDisplay_Mono16.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxIpeDisplay_Mono16.OcxState")));
            this.axAxIpeDisplay_Mono16.Size = new System.Drawing.Size(481, 497);
            this.axAxIpeDisplay_Mono16.TabIndex = 4;
            // 
            // axAxIpeDisplay_Mono8
            // 
            this.axAxIpeDisplay_Mono8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAxIpeDisplay_Mono8.Enabled = true;
            this.axAxIpeDisplay_Mono8.Location = new System.Drawing.Point(977, 43);
            this.axAxIpeDisplay_Mono8.Name = "axAxIpeDisplay_Mono8";
            this.axAxIpeDisplay_Mono8.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxIpeDisplay_Mono8.OcxState")));
            this.axAxIpeDisplay_Mono8.Size = new System.Drawing.Size(484, 497);
            this.axAxIpeDisplay_Mono8.TabIndex = 5;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 693);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Main";
            this.Text = "Sherlock";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAxIpeDisplay_3DCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxIpeDisplay_Mono16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxIpeDisplay_Mono8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Terminate;
        private System.Windows.Forms.Button btn_Halt;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_Initialize;
        private System.Windows.Forms.Button btn_FileLoad;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Distance;
        private System.Windows.Forms.TextBox textBox_highHeight;
        private System.Windows.Forms.TextBox textBox_BottomHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AxipedisplayctrlLib.AxAxIpeDisplay axAxIpeDisplay_3DCloud;
        private AxipedisplayctrlLib.AxAxIpeDisplay axAxIpeDisplay_Mono16;
        private AxipedisplayctrlLib.AxAxIpeDisplay axAxIpeDisplay_Mono8;
    }
}

