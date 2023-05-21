namespace WEEK12_15MEI2023
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.tb_pos = new System.Windows.Forms.TextBox();
            this.tb_teamnum = new System.Windows.Forms.TextBox();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.butt_add = new System.Windows.Forms.Button();
            this.CB_nationality = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripADD = new System.Windows.Forms.ToolStripLabel();
            this.toolStripEDIT = new System.Windows.Forms.ToolStripLabel();
            this.toolStripremove = new System.Windows.Forms.ToolStripLabel();
            this.paneladdplayer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butt_delete = new System.Windows.Forms.Button();
            this.dgv_team = new System.Windows.Forms.DataGridView();
            this.CB_teamname1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paneleditmanager = new System.Windows.Forms.Panel();
            this.butt_update = new System.Windows.Forms.Button();
            this.dgv_manager2 = new System.Windows.Forms.DataGridView();
            this.dgv_manager1 = new System.Windows.Forms.DataGridView();
            this.CB_teamname2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_teamname = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_playerid = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.paneladdplayer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_team)).BeginInit();
            this.paneleditmanager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthdate :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Weight :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Height :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Position :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nationality :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Team Number :";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(158, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(199, 26);
            this.tb_name.TabIndex = 10;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(158, 184);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(200, 26);
            this.tb_weight.TabIndex = 16;
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(158, 150);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(201, 26);
            this.tb_height.TabIndex = 17;
            // 
            // tb_pos
            // 
            this.tb_pos.Location = new System.Drawing.Point(158, 117);
            this.tb_pos.Name = "tb_pos";
            this.tb_pos.Size = new System.Drawing.Size(200, 26);
            this.tb_pos.TabIndex = 18;
            // 
            // tb_teamnum
            // 
            this.tb_teamnum.Location = new System.Drawing.Point(158, 46);
            this.tb_teamnum.Name = "tb_teamnum";
            this.tb_teamnum.Size = new System.Drawing.Size(199, 26);
            this.tb_teamnum.TabIndex = 20;
            // 
            // date_birth
            // 
            this.date_birth.Location = new System.Drawing.Point(157, 216);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(200, 26);
            this.date_birth.TabIndex = 21;
            // 
            // butt_add
            // 
            this.butt_add.Location = new System.Drawing.Point(157, 322);
            this.butt_add.Name = "butt_add";
            this.butt_add.Size = new System.Drawing.Size(115, 39);
            this.butt_add.TabIndex = 23;
            this.butt_add.Text = "Add";
            this.butt_add.UseVisualStyleBackColor = true;
            this.butt_add.Click += new System.EventHandler(this.butt_add_Click);
            // 
            // CB_nationality
            // 
            this.CB_nationality.FormattingEnabled = true;
            this.CB_nationality.Location = new System.Drawing.Point(158, 78);
            this.CB_nationality.Name = "CB_nationality";
            this.CB_nationality.Size = new System.Drawing.Size(199, 28);
            this.CB_nationality.TabIndex = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripADD,
            this.toolStripEDIT,
            this.toolStripremove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1024, 30);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripADD
            // 
            this.toolStripADD.Name = "toolStripADD";
            this.toolStripADD.Size = new System.Drawing.Size(115, 25);
            this.toolStripADD.Text = "ADD PLAYER";
            this.toolStripADD.Click += new System.EventHandler(this.toolStripADD_Click);
            // 
            // toolStripEDIT
            // 
            this.toolStripEDIT.Name = "toolStripEDIT";
            this.toolStripEDIT.Size = new System.Drawing.Size(138, 25);
            this.toolStripEDIT.Text = "EDIT MANAGER";
            this.toolStripEDIT.Click += new System.EventHandler(this.toolStripEDIT_Click);
            // 
            // toolStripremove
            // 
            this.toolStripremove.Name = "toolStripremove";
            this.toolStripremove.Size = new System.Drawing.Size(147, 25);
            this.toolStripremove.Text = "REMOVE PLAYER";
            // 
            // paneladdplayer
            // 
            this.paneladdplayer.Controls.Add(this.label11);
            this.paneladdplayer.Controls.Add(this.textBox_playerid);
            this.paneladdplayer.Controls.Add(this.CB_teamname);
            this.paneladdplayer.Controls.Add(this.tb_height);
            this.paneladdplayer.Controls.Add(this.label2);
            this.paneladdplayer.Controls.Add(this.CB_nationality);
            this.paneladdplayer.Controls.Add(this.label4);
            this.paneladdplayer.Controls.Add(this.butt_add);
            this.paneladdplayer.Controls.Add(this.label5);
            this.paneladdplayer.Controls.Add(this.label6);
            this.paneladdplayer.Controls.Add(this.date_birth);
            this.paneladdplayer.Controls.Add(this.label7);
            this.paneladdplayer.Controls.Add(this.tb_teamnum);
            this.paneladdplayer.Controls.Add(this.label8);
            this.paneladdplayer.Controls.Add(this.tb_pos);
            this.paneladdplayer.Controls.Add(this.label9);
            this.paneladdplayer.Controls.Add(this.label10);
            this.paneladdplayer.Controls.Add(this.tb_weight);
            this.paneladdplayer.Controls.Add(this.tb_name);
            this.paneladdplayer.Location = new System.Drawing.Point(12, 66);
            this.paneladdplayer.Name = "paneladdplayer";
            this.paneladdplayer.Size = new System.Drawing.Size(430, 364);
            this.paneladdplayer.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butt_delete);
            this.panel2.Controls.Add(this.dgv_team);
            this.panel2.Controls.Add(this.CB_teamname1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(448, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 364);
            this.panel2.TabIndex = 28;
            // 
            // butt_delete
            // 
            this.butt_delete.Location = new System.Drawing.Point(21, 322);
            this.butt_delete.Name = "butt_delete";
            this.butt_delete.Size = new System.Drawing.Size(115, 39);
            this.butt_delete.TabIndex = 26;
            this.butt_delete.Text = "Delete";
            this.butt_delete.UseVisualStyleBackColor = true;
            this.butt_delete.Click += new System.EventHandler(this.butt_delete_Click);
            // 
            // dgv_team
            // 
            this.dgv_team.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_team.Location = new System.Drawing.Point(21, 52);
            this.dgv_team.Name = "dgv_team";
            this.dgv_team.RowHeadersWidth = 62;
            this.dgv_team.RowTemplate.Height = 28;
            this.dgv_team.Size = new System.Drawing.Size(519, 260);
            this.dgv_team.TabIndex = 2;
            this.dgv_team.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_team_CellClick);
            // 
            // CB_teamname1
            // 
            this.CB_teamname1.FormattingEnabled = true;
            this.CB_teamname1.Location = new System.Drawing.Point(141, 12);
            this.CB_teamname1.Name = "CB_teamname1";
            this.CB_teamname1.Size = new System.Drawing.Size(185, 28);
            this.CB_teamname1.TabIndex = 1;
            this.CB_teamname1.SelectionChangeCommitted += new System.EventHandler(this.CB_teamname1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name :";
            // 
            // paneleditmanager
            // 
            this.paneleditmanager.Controls.Add(this.butt_update);
            this.paneleditmanager.Controls.Add(this.dgv_manager2);
            this.paneleditmanager.Controls.Add(this.dgv_manager1);
            this.paneleditmanager.Controls.Add(this.CB_teamname2);
            this.paneleditmanager.Controls.Add(this.label3);
            this.paneleditmanager.Location = new System.Drawing.Point(12, 437);
            this.paneleditmanager.Name = "paneleditmanager";
            this.paneleditmanager.Size = new System.Drawing.Size(1000, 452);
            this.paneleditmanager.TabIndex = 29;
            // 
            // butt_update
            // 
            this.butt_update.Location = new System.Drawing.Point(16, 326);
            this.butt_update.Name = "butt_update";
            this.butt_update.Size = new System.Drawing.Size(115, 39);
            this.butt_update.TabIndex = 26;
            this.butt_update.Text = "Add";
            this.butt_update.UseVisualStyleBackColor = true;
            this.butt_update.Click += new System.EventHandler(this.butt_update_Click);
            // 
            // dgv_manager2
            // 
            this.dgv_manager2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manager2.Location = new System.Drawing.Point(505, 53);
            this.dgv_manager2.Name = "dgv_manager2";
            this.dgv_manager2.RowHeadersWidth = 62;
            this.dgv_manager2.RowTemplate.Height = 28;
            this.dgv_manager2.Size = new System.Drawing.Size(477, 267);
            this.dgv_manager2.TabIndex = 29;
            this.dgv_manager2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_manager2_CellClick);
            // 
            // dgv_manager1
            // 
            this.dgv_manager1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manager1.Location = new System.Drawing.Point(14, 53);
            this.dgv_manager1.Name = "dgv_manager1";
            this.dgv_manager1.RowHeadersWidth = 62;
            this.dgv_manager1.RowTemplate.Height = 28;
            this.dgv_manager1.Size = new System.Drawing.Size(485, 267);
            this.dgv_manager1.TabIndex = 28;
            // 
            // CB_teamname2
            // 
            this.CB_teamname2.FormattingEnabled = true;
            this.CB_teamname2.Location = new System.Drawing.Point(157, 17);
            this.CB_teamname2.Name = "CB_teamname2";
            this.CB_teamname2.Size = new System.Drawing.Size(185, 28);
            this.CB_teamname2.TabIndex = 27;
            this.CB_teamname2.SelectedIndexChanged += new System.EventHandler(this.CB_teamname2_SelectedIndexChanged);
            this.CB_teamname2.SelectionChangeCommitted += new System.EventHandler(this.CB_teamname2_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Team Name :";
            // 
            // CB_teamname
            // 
            this.CB_teamname.FormattingEnabled = true;
            this.CB_teamname.Location = new System.Drawing.Point(157, 252);
            this.CB_teamname.Name = "CB_teamname";
            this.CB_teamname.Size = new System.Drawing.Size(202, 28);
            this.CB_teamname.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Player ID :";
            // 
            // textBox_playerid
            // 
            this.textBox_playerid.Location = new System.Drawing.Point(158, 286);
            this.textBox_playerid.Name = "textBox_playerid";
            this.textBox_playerid.Size = new System.Drawing.Size(200, 26);
            this.textBox_playerid.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 884);
            this.Controls.Add(this.paneleditmanager);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paneladdplayer);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.paneladdplayer.ResumeLayout(false);
            this.paneladdplayer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_team)).EndInit();
            this.paneleditmanager.ResumeLayout(false);
            this.paneleditmanager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.TextBox tb_pos;
        private System.Windows.Forms.TextBox tb_teamnum;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.Button butt_add;
        private System.Windows.Forms.ComboBox CB_nationality;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripADD;
        private System.Windows.Forms.ToolStripLabel toolStripEDIT;
        private System.Windows.Forms.ToolStripLabel toolStripremove;
        private System.Windows.Forms.Panel paneladdplayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CB_teamname1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_team;
        private System.Windows.Forms.Button butt_delete;
        private System.Windows.Forms.Panel paneleditmanager;
        private System.Windows.Forms.DataGridView dgv_manager1;
        private System.Windows.Forms.ComboBox CB_teamname2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_manager2;
        private System.Windows.Forms.Button butt_update;
        private System.Windows.Forms.ComboBox CB_teamname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_playerid;
    }
}

