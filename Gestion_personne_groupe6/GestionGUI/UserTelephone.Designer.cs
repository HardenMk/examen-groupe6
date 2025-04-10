namespace GestionGUI
{
    partial class UserTelephone
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTelephone));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.copierToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnsupp = new System.Windows.Forms.Button();
            this.txtrech = new System.Windows.Forms.TextBox();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnajout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.enregistrerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.couperToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toollabelnumero = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toollabelnbrgridvieuw = new System.Windows.Forms.ToolStripLabel();
            this.pnlrecette = new System.Windows.Forms.Panel();
            this.imprimerListeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.description_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dvgclient = new System.Windows.Forms.DataGridView();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noms_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.pnlrecette.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).BeginInit();
            this.SuspendLayout();
            // 
            // copierToolStripButton
            // 
            this.copierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copierToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripButton.Image")));
            this.copierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copierToolStripButton.Name = "copierToolStripButton";
            this.copierToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copierToolStripButton.Text = "Co&pier";
            // 
            // btnsupp
            // 
            this.btnsupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsupp.FlatAppearance.BorderSize = 0;
            this.btnsupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnsupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnsupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.ForeColor = System.Drawing.Color.Black;
            this.btnsupp.Image = ((System.Drawing.Image)(resources.GetObject("btnsupp.Image")));
            this.btnsupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupp.Location = new System.Drawing.Point(342, 20);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(170, 24);
            this.btnsupp.TabIndex = 62;
            this.btnsupp.Text = "Supprimer Numero";
            this.btnsupp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsupp.UseVisualStyleBackColor = false;
            // 
            // txtrech
            // 
            this.txtrech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrech.Location = new System.Drawing.Point(570, 18);
            this.txtrech.Multiline = true;
            this.txtrech.Name = "txtrech";
            this.txtrech.Size = new System.Drawing.Size(274, 30);
            this.txtrech.TabIndex = 60;
            this.txtrech.Text = "Recherche";
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnmod.FlatAppearance.BorderSize = 0;
            this.btnmod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnmod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.ForeColor = System.Drawing.Color.Black;
            this.btnmod.Image = ((System.Drawing.Image)(resources.GetObject("btnmod.Image")));
            this.btnmod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmod.Location = new System.Drawing.Point(179, 21);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(161, 24);
            this.btnmod.TabIndex = 8;
            this.btnmod.Text = "Modifier Numero";
            this.btnmod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmod.UseVisualStyleBackColor = false;
            // 
            // btnajout
            // 
            this.btnajout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnajout.FlatAppearance.BorderSize = 0;
            this.btnajout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnajout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnajout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajout.ForeColor = System.Drawing.Color.Black;
            this.btnajout.Image = ((System.Drawing.Image)(resources.GetObject("btnajout.Image")));
            this.btnajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajout.Location = new System.Drawing.Point(16, 21);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(163, 24);
            this.btnajout.TabIndex = 7;
            this.btnajout.Text = "Nouveau Numero";
            this.btnajout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnajout.UseVisualStyleBackColor = false;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnsupp);
            this.groupBox1.Controls.Add(this.txtrech);
            this.groupBox1.Controls.Add(this.btnmod);
            this.groupBox1.Controls.Add(this.btnajout);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(1, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 29);
            this.panel1.TabIndex = 38;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripButton,
            this.imprimerToolStripButton,
            this.toolStripSeparator,
            this.couperToolStripButton,
            this.copierToolStripButton,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toollabelnumero,
            this.toolStripLabel2,
            this.toollabelnbrgridvieuw});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(169, 25);
            this.toolStrip2.TabIndex = 19;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // enregistrerToolStripButton
            // 
            this.enregistrerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enregistrerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripButton.Image")));
            this.enregistrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripButton.Name = "enregistrerToolStripButton";
            this.enregistrerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.enregistrerToolStripButton.Text = "&Enregistrer";
            // 
            // imprimerToolStripButton
            // 
            this.imprimerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripButton.Image")));
            this.imprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimerToolStripButton.Name = "imprimerToolStripButton";
            this.imprimerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimerToolStripButton.Text = "&Imprimer";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // couperToolStripButton
            // 
            this.couperToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.couperToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripButton.Image")));
            this.couperToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.couperToolStripButton.Name = "couperToolStripButton";
            this.couperToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.couperToolStripButton.Text = "C&ouper";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toollabelnumero
            // 
            this.toollabelnumero.Name = "toollabelnumero";
            this.toollabelnumero.Size = new System.Drawing.Size(13, 22);
            this.toollabelnumero.Text = "0";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(21, 22);
            this.toolStripLabel2.Text = "on";
            // 
            // toollabelnbrgridvieuw
            // 
            this.toollabelnbrgridvieuw.Name = "toollabelnbrgridvieuw";
            this.toollabelnbrgridvieuw.Size = new System.Drawing.Size(13, 22);
            this.toollabelnbrgridvieuw.Text = "1";
            // 
            // pnlrecette
            // 
            this.pnlrecette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlrecette.BackColor = System.Drawing.SystemColors.Control;
            this.pnlrecette.Controls.Add(this.groupBox1);
            this.pnlrecette.Location = new System.Drawing.Point(0, 0);
            this.pnlrecette.Name = "pnlrecette";
            this.pnlrecette.Size = new System.Drawing.Size(1044, 76);
            this.pnlrecette.TabIndex = 37;
            // 
            // imprimerListeClientToolStripMenuItem
            // 
            this.imprimerListeClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerListeClientToolStripMenuItem.Image")));
            this.imprimerListeClientToolStripMenuItem.Name = "imprimerListeClientToolStripMenuItem";
            this.imprimerListeClientToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.imprimerListeClientToolStripMenuItem.Text = "Imprimer liste client";
            // 
            // supprimerPersonnelToolStripMenuItem
            // 
            this.supprimerPersonnelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supprimerPersonnelToolStripMenuItem.Image")));
            this.supprimerPersonnelToolStripMenuItem.Name = "supprimerPersonnelToolStripMenuItem";
            this.supprimerPersonnelToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.supprimerPersonnelToolStripMenuItem.Text = "Supprimer client";
            // 
            // modifierPersonnelToolStripMenuItem
            // 
            this.modifierPersonnelToolStripMenuItem.Name = "modifierPersonnelToolStripMenuItem";
            this.modifierPersonnelToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modifierPersonnelToolStripMenuItem.Text = "Modifier client";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierPersonnelToolStripMenuItem,
            this.supprimerPersonnelToolStripMenuItem,
            this.actualiserToolStripMenuItem,
            this.imprimerListeClientToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(180, 92);
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.actualiserToolStripMenuItem.Text = "Actualiser";
            // 
            // description_client
            // 
            this.description_client.DataPropertyName = "description_client";
            this.description_client.HeaderText = "Description";
            this.description_client.Name = "description_client";
            this.description_client.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // categorie
            // 
            this.categorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categorie.DataPropertyName = "categorie";
            this.categorie.HeaderText = "Categorie";
            this.categorie.Name = "categorie";
            this.categorie.ReadOnly = true;
            // 
            // dvgclient
            // 
            this.dvgclient.AllowUserToAddRows = false;
            this.dvgclient.AllowUserToDeleteRows = false;
            this.dvgclient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgclient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgclient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_client,
            this.noms_client,
            this.adresse_client,
            this.telephone_client,
            this.categorie,
            this.email,
            this.description_client});
            this.dvgclient.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgclient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgclient.EnableHeadersVisualStyles = false;
            this.dvgclient.Location = new System.Drawing.Point(0, 119);
            this.dvgclient.Name = "dvgclient";
            this.dvgclient.ReadOnly = true;
            this.dvgclient.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dvgclient.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgclient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgclient.Size = new System.Drawing.Size(1044, 375);
            this.dvgclient.TabIndex = 39;
            // 
            // id_client
            // 
            this.id_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_client.DataPropertyName = "id_client";
            this.id_client.HeaderText = "Id";
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            // 
            // noms_client
            // 
            this.noms_client.DataPropertyName = "noms_client";
            this.noms_client.HeaderText = "Noms";
            this.noms_client.Name = "noms_client";
            this.noms_client.ReadOnly = true;
            // 
            // adresse_client
            // 
            this.adresse_client.DataPropertyName = "adresse_client";
            this.adresse_client.HeaderText = "Adresse";
            this.adresse_client.Name = "adresse_client";
            this.adresse_client.ReadOnly = true;
            // 
            // telephone_client
            // 
            this.telephone_client.DataPropertyName = "telephone_client";
            this.telephone_client.HeaderText = "Telephone";
            this.telephone_client.Name = "telephone_client";
            this.telephone_client.ReadOnly = true;
            // 
            // UserTelephone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlrecette);
            this.Controls.Add(this.dvgclient);
            this.Name = "UserTelephone";
            this.Size = new System.Drawing.Size(1044, 495);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.pnlrecette.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton copierToolStripButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.TextBox txtrech;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnajout;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton enregistrerToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton couperToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toollabelnumero;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toollabelnbrgridvieuw;
        public System.Windows.Forms.Panel pnlrecette;
        private System.Windows.Forms.ToolStripMenuItem imprimerListeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerPersonnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierPersonnelToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn description_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dvgclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn noms_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone_client;
    }
}
