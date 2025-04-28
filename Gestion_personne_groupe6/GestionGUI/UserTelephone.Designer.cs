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
            this.btnmod = new System.Windows.Forms.Button();
            this.btnajout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrech = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.enregistrerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.couperToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimerToolStripButton = new System.Windows.Forms.ToolStripButton();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dvgphone = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noms_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.pnlrecette.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgphone)).BeginInit();
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
            this.copierToolStripButton.Click += new System.EventHandler(this.copierToolStripButton_Click);
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
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
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
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
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
            this.groupBox1.Controls.Add(this.txtrech);
            this.groupBox1.Controls.Add(this.btnsupp);
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
            // txtrech
            // 
            this.txtrech.BorderThickness = 2;
            this.txtrech.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrech.DefaultText = "";
            this.txtrech.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtrech.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtrech.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtrech.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtrech.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrech.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtrech.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrech.Location = new System.Drawing.Point(571, 16);
            this.txtrech.Name = "txtrech";
            this.txtrech.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtrech.PlaceholderText = "Recherche";
            this.txtrech.SelectedText = "";
            this.txtrech.Size = new System.Drawing.Size(262, 29);
            this.txtrech.TabIndex = 64;
            this.txtrech.TextChanged += new System.EventHandler(this.txtrech_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(1, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 29);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripButton,
            this.toolStripSeparator,
            this.couperToolStripButton,
            this.copierToolStripButton,
            this.imprimerToolStripButton,
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
            this.enregistrerToolStripButton.Click += new System.EventHandler(this.enregistrerToolStripButton_Click);
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
            this.couperToolStripButton.Click += new System.EventHandler(this.couperToolStripButton_Click);
            // 
            // imprimerToolStripButton
            // 
            this.imprimerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripButton.Image")));
            this.imprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimerToolStripButton.Name = "imprimerToolStripButton";
            this.imprimerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimerToolStripButton.Text = "&Imprimer";
            this.imprimerToolStripButton.Click += new System.EventHandler(this.imprimerToolStripButton_Click);
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
            this.pnlrecette.BackColor = System.Drawing.Color.White;
            this.pnlrecette.Controls.Add(this.groupBox1);
            this.pnlrecette.Location = new System.Drawing.Point(0, 0);
            this.pnlrecette.Name = "pnlrecette";
            this.pnlrecette.Size = new System.Drawing.Size(1044, 76);
            this.pnlrecette.TabIndex = 37;
            this.pnlrecette.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlrecette_Paint);
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
            // dvgphone
            // 
            this.dvgphone.AllowUserToAddRows = false;
            this.dvgphone.AllowUserToDeleteRows = false;
            this.dvgphone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgphone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgphone.BackgroundColor = System.Drawing.Color.White;
            this.dvgphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgphone.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgphone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgphone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.noms_client,
            this.Postnom,
            this.Prenom,
            this.NumeroComplet,
            this.nomComplet,
            this.initial,
            this.numero});
            this.dvgphone.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgphone.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgphone.EnableHeadersVisualStyles = false;
            this.dvgphone.Location = new System.Drawing.Point(0, 119);
            this.dvgphone.Name = "dvgphone";
            this.dvgphone.ReadOnly = true;
            this.dvgphone.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dvgphone.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgphone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgphone.Size = new System.Drawing.Size(1044, 375);
            this.dvgphone.TabIndex = 39;
            this.dvgphone.Click += new System.EventHandler(this.dvgphone_Click);
            this.dvgphone.DoubleClick += new System.EventHandler(this.dvgphone_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // noms_client
            // 
            this.noms_client.HeaderText = "Nom";
            this.noms_client.Name = "noms_client";
            this.noms_client.ReadOnly = true;
            // 
            // Postnom
            // 
            this.Postnom.HeaderText = "Postnom";
            this.Postnom.Name = "Postnom";
            this.Postnom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // NumeroComplet
            // 
            this.NumeroComplet.DataPropertyName = "numeroComplet";
            this.NumeroComplet.HeaderText = "Numero";
            this.NumeroComplet.Name = "NumeroComplet";
            this.NumeroComplet.ReadOnly = true;
            // 
            // nomComplet
            // 
            this.nomComplet.HeaderText = "nomComplet";
            this.nomComplet.Name = "nomComplet";
            this.nomComplet.ReadOnly = true;
            this.nomComplet.Visible = false;
            // 
            // initial
            // 
            this.initial.HeaderText = "initial";
            this.initial.Name = "initial";
            this.initial.ReadOnly = true;
            this.initial.Visible = false;
            // 
            // numero
            // 
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Visible = false;
            // 
            // UserTelephone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlrecette);
            this.Controls.Add(this.dvgphone);
            this.Name = "UserTelephone";
            this.Size = new System.Drawing.Size(1044, 495);
            this.Load += new System.EventHandler(this.UserTelephone_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.pnlrecette.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgphone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton copierToolStripButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnsupp;
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
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.DataGridView dvgphone;
        private Guna.UI2.WinForms.Guna2TextBox txtrech;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn noms_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroComplet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomComplet;
        private System.Windows.Forms.DataGridViewTextBoxColumn initial;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
    }
}
