namespace GestionGUI
{
    partial class UserPersonne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPersonne));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.couperToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copierToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toollabelnumero = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toollabelnbrgridvieuw = new System.Windows.Forms.ToolStripLabel();
            this.dgvPersonne = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomComplet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.modifierPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerListeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlrecette = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrech = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnsupp = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnajout = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gestion_personneDataSet = new GestionGUI.gestion_personneDataSet();
            this.spselectpersonnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_select_personnesTableAdapter = new GestionGUI.gestion_personneDataSetTableAdapters.sp_select_personnesTableAdapter();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlrecette.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_personneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectpersonnesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.actualiserToolStripMenuItem.Text = "Actualiser";
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
            this.toolStrip2.Size = new System.Drawing.Size(202, 25);
            this.toolStrip2.TabIndex = 19;
            this.toolStrip2.Text = "toolStrip2";
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
            // copierToolStripButton
            // 
            this.copierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copierToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripButton.Image")));
            this.copierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copierToolStripButton.Name = "copierToolStripButton";
            this.copierToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copierToolStripButton.Text = "Modifier";
            this.copierToolStripButton.Click += new System.EventHandler(this.copierToolStripButton_Click);
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
            this.toolStripLabel2.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel2.Text = "sur";
            // 
            // toollabelnbrgridvieuw
            // 
            this.toollabelnbrgridvieuw.Name = "toollabelnbrgridvieuw";
            this.toollabelnbrgridvieuw.Size = new System.Drawing.Size(13, 22);
            this.toollabelnbrgridvieuw.Text = "1";
            // 
            // dgvPersonne
            // 
            this.dgvPersonne.AllowUserToAddRows = false;
            this.dgvPersonne.AllowUserToDeleteRows = false;
            this.dgvPersonne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonne.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersonne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonne.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nom,
            this.postnom,
            this.prenom,
            this.sex,
            this.nomComplet});
            this.dgvPersonne.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonne.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonne.EnableHeadersVisualStyles = false;
            this.dgvPersonne.Location = new System.Drawing.Point(0, 119);
            this.dgvPersonne.Name = "dgvPersonne";
            this.dgvPersonne.ReadOnly = true;
            this.dgvPersonne.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPersonne.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonne.Size = new System.Drawing.Size(1044, 375);
            this.dgvPersonne.TabIndex = 36;
            this.dgvPersonne.Click += new System.EventHandler(this.dgvPersonne_Click);
            this.dgvPersonne.DoubleClick += new System.EventHandler(this.dgvPersonne_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "Nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // postnom
            // 
            this.postnom.DataPropertyName = "Postnom";
            this.postnom.HeaderText = "Postnom";
            this.postnom.Name = "postnom";
            this.postnom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "Prenom";
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "Sex";
            this.sex.HeaderText = "Genre";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // nomComplet
            // 
            this.nomComplet.DataPropertyName = "NomComplet";
            this.nomComplet.HeaderText = "Noms";
            this.nomComplet.Name = "nomComplet";
            this.nomComplet.ReadOnly = true;
            this.nomComplet.Visible = false;
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
            // modifierPersonnelToolStripMenuItem
            // 
            this.modifierPersonnelToolStripMenuItem.Name = "modifierPersonnelToolStripMenuItem";
            this.modifierPersonnelToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modifierPersonnelToolStripMenuItem.Text = "Modifier client";
            // 
            // supprimerPersonnelToolStripMenuItem
            // 
            this.supprimerPersonnelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supprimerPersonnelToolStripMenuItem.Image")));
            this.supprimerPersonnelToolStripMenuItem.Name = "supprimerPersonnelToolStripMenuItem";
            this.supprimerPersonnelToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.supprimerPersonnelToolStripMenuItem.Text = "Supprimer client";
            // 
            // imprimerListeClientToolStripMenuItem
            // 
            this.imprimerListeClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerListeClientToolStripMenuItem.Image")));
            this.imprimerListeClientToolStripMenuItem.Name = "imprimerListeClientToolStripMenuItem";
            this.imprimerListeClientToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.imprimerListeClientToolStripMenuItem.Text = "Imprimer liste client";
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
            this.panel1.TabIndex = 35;
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
            this.pnlrecette.TabIndex = 34;
            this.pnlrecette.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlrecette_Paint);
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
            this.txtrech.Location = new System.Drawing.Point(627, 15);
            this.txtrech.Name = "txtrech";
            this.txtrech.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtrech.PlaceholderText = "Recherche";
            this.txtrech.SelectedText = "";
            this.txtrech.Size = new System.Drawing.Size(262, 29);
            this.txtrech.TabIndex = 63;
            this.txtrech.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
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
            this.btnsupp.Text = "Supprimer personne";
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
            this.btnmod.Text = "Modifier personne";
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
            this.btnajout.Text = "Nouvelle personne";
            this.btnajout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnajout.UseVisualStyleBackColor = false;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // gestion_personneDataSet
            // 
            this.gestion_personneDataSet.DataSetName = "gestion_personneDataSet";
            this.gestion_personneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spselectpersonnesBindingSource
            // 
            this.spselectpersonnesBindingSource.DataMember = "sp_select_personnes";
            this.spselectpersonnesBindingSource.DataSource = this.gestion_personneDataSet;
            // 
            // sp_select_personnesTableAdapter
            // 
            this.sp_select_personnesTableAdapter.ClearBeforeFill = true;
            // 
            // UserPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvPersonne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlrecette);
            this.Name = "UserPersonne";
            this.Size = new System.Drawing.Size(1044, 495);
            this.Load += new System.EventHandler(this.UserPersonne_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlrecette.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_personneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spselectpersonnesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton enregistrerToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton imprimerToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton couperToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toollabelnumero;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toollabelnbrgridvieuw;
        public System.Windows.Forms.DataGridView dgvPersonne;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierPersonnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerPersonnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerListeClientToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlrecette;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnajout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripButton copierToolStripButton;
        private System.Windows.Forms.BindingSource spselectpersonnesBindingSource;
        private gestion_personneDataSet gestion_personneDataSet;
        private gestion_personneDataSetTableAdapters.sp_select_personnesTableAdapter sp_select_personnesTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox txtrech;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomComplet;
    }
}
