//written by Ryan Guilherme Morais Nascimento (ryanguilhermetbt@gmail.com)

namespace hotel_system
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            menuStrip1 = new MenuStrip();
            MenuCadastro = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            hóspedesToolStripMenuItem = new ToolStripMenuItem();
            quartosToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            serviçosToolStripMenuItem = new ToolStripMenuItem();
            MenuProdutos = new ToolStripMenuItem();
            novoProdutoToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            MenuMovimentacoes = new ToolStripMenuItem();
            novaVendaToolStripMenuItem = new ToolStripMenuItem();
            novoServiçoToolStripMenuItem1 = new ToolStripMenuItem();
            entradasESaídasToolStripMenuItem = new ToolStripMenuItem();
            MenuReservas = new ToolStripMenuItem();
            novaReservaToolStripMenuItem = new ToolStripMenuItem();
            quadroDeReservasToolStripMenuItem = new ToolStripMenuItem();
            consultarReservasToolStripMenuItem = new ToolStripMenuItem();
            MenuCheckInOut = new ToolStripMenuItem();
            novoServiçoToolStripMenuItem = new ToolStripMenuItem();
            checkOutToolStripMenuItem = new ToolStripMenuItem();
            MenuRelatorios = new ToolStripMenuItem();
            MenuSair = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            TopPanel = new Panel();
            RightPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            RightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuCadastro, MenuProdutos, MenuMovimentacoes, MenuReservas, MenuCheckInOut, MenuRelatorios, MenuSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            MenuCadastro.DropDownItems.AddRange(new ToolStripItem[] { funcionáriosToolStripMenuItem, hóspedesToolStripMenuItem, quartosToolStripMenuItem, usuáriosToolStripMenuItem, serviçosToolStripMenuItem });
            MenuCadastro.Image = (Image)resources.GetObject("MenuCadastro.Image");
            MenuCadastro.Name = "MenuCadastro";
            MenuCadastro.Size = new Size(87, 20);
            MenuCadastro.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Image = (Image)resources.GetObject("funcionáriosToolStripMenuItem.Image");
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(142, 22);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // hóspedesToolStripMenuItem
            // 
            hóspedesToolStripMenuItem.Image = (Image)resources.GetObject("hóspedesToolStripMenuItem.Image");
            hóspedesToolStripMenuItem.Name = "hóspedesToolStripMenuItem";
            hóspedesToolStripMenuItem.Size = new Size(142, 22);
            hóspedesToolStripMenuItem.Text = "Hóspedes";
            // 
            // quartosToolStripMenuItem
            // 
            quartosToolStripMenuItem.Image = (Image)resources.GetObject("quartosToolStripMenuItem.Image");
            quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            quartosToolStripMenuItem.Size = new Size(142, 22);
            quartosToolStripMenuItem.Text = "Quartos";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Image = (Image)resources.GetObject("usuáriosToolStripMenuItem.Image");
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(142, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // serviçosToolStripMenuItem
            // 
            serviçosToolStripMenuItem.Image = (Image)resources.GetObject("serviçosToolStripMenuItem.Image");
            serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            serviçosToolStripMenuItem.Size = new Size(142, 22);
            serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // MenuProdutos
            // 
            MenuProdutos.DropDownItems.AddRange(new ToolStripItem[] { novoProdutoToolStripMenuItem, estoqueToolStripMenuItem });
            MenuProdutos.Image = (Image)resources.GetObject("MenuProdutos.Image");
            MenuProdutos.Name = "MenuProdutos";
            MenuProdutos.Size = new Size(83, 20);
            MenuProdutos.Text = "Produtos";
            // 
            // novoProdutoToolStripMenuItem
            // 
            novoProdutoToolStripMenuItem.Image = (Image)resources.GetObject("novoProdutoToolStripMenuItem.Image");
            novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            novoProdutoToolStripMenuItem.Size = new Size(149, 22);
            novoProdutoToolStripMenuItem.Text = "Novo Produto";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Image = (Image)resources.GetObject("estoqueToolStripMenuItem.Image");
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(149, 22);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // MenuMovimentacoes
            // 
            MenuMovimentacoes.DropDownItems.AddRange(new ToolStripItem[] { novaVendaToolStripMenuItem, novoServiçoToolStripMenuItem1, entradasESaídasToolStripMenuItem });
            MenuMovimentacoes.Image = (Image)resources.GetObject("MenuMovimentacoes.Image");
            MenuMovimentacoes.Name = "MenuMovimentacoes";
            MenuMovimentacoes.Size = new Size(120, 20);
            MenuMovimentacoes.Text = "Movimentações";
            // 
            // novaVendaToolStripMenuItem
            // 
            novaVendaToolStripMenuItem.Image = (Image)resources.GetObject("novaVendaToolStripMenuItem.Image");
            novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            novaVendaToolStripMenuItem.Size = new Size(164, 22);
            novaVendaToolStripMenuItem.Text = "Nova Venda";
            // 
            // novoServiçoToolStripMenuItem1
            // 
            novoServiçoToolStripMenuItem1.Image = (Image)resources.GetObject("novoServiçoToolStripMenuItem1.Image");
            novoServiçoToolStripMenuItem1.Name = "novoServiçoToolStripMenuItem1";
            novoServiçoToolStripMenuItem1.Size = new Size(164, 22);
            novoServiçoToolStripMenuItem1.Text = "Novo Serviço";
            // 
            // entradasESaídasToolStripMenuItem
            // 
            entradasESaídasToolStripMenuItem.Image = (Image)resources.GetObject("entradasESaídasToolStripMenuItem.Image");
            entradasESaídasToolStripMenuItem.Name = "entradasESaídasToolStripMenuItem";
            entradasESaídasToolStripMenuItem.Size = new Size(164, 22);
            entradasESaídasToolStripMenuItem.Text = "Entradas e Saídas";
            // 
            // MenuReservas
            // 
            MenuReservas.DropDownItems.AddRange(new ToolStripItem[] { novaReservaToolStripMenuItem, quadroDeReservasToolStripMenuItem, consultarReservasToolStripMenuItem });
            MenuReservas.Image = (Image)resources.GetObject("MenuReservas.Image");
            MenuReservas.Name = "MenuReservas";
            MenuReservas.Size = new Size(80, 20);
            MenuReservas.Text = "Reservas";
            // 
            // novaReservaToolStripMenuItem
            // 
            novaReservaToolStripMenuItem.Image = (Image)resources.GetObject("novaReservaToolStripMenuItem.Image");
            novaReservaToolStripMenuItem.Name = "novaReservaToolStripMenuItem";
            novaReservaToolStripMenuItem.Size = new Size(178, 22);
            novaReservaToolStripMenuItem.Text = "Nova Reserva";
            // 
            // quadroDeReservasToolStripMenuItem
            // 
            quadroDeReservasToolStripMenuItem.Image = (Image)resources.GetObject("quadroDeReservasToolStripMenuItem.Image");
            quadroDeReservasToolStripMenuItem.Name = "quadroDeReservasToolStripMenuItem";
            quadroDeReservasToolStripMenuItem.Size = new Size(178, 22);
            quadroDeReservasToolStripMenuItem.Text = "Quadro de Reservas";
            // 
            // consultarReservasToolStripMenuItem
            // 
            consultarReservasToolStripMenuItem.Image = (Image)resources.GetObject("consultarReservasToolStripMenuItem.Image");
            consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            consultarReservasToolStripMenuItem.Size = new Size(178, 22);
            consultarReservasToolStripMenuItem.Text = "Consultar Reservas";
            // 
            // MenuCheckInOut
            // 
            MenuCheckInOut.DropDownItems.AddRange(new ToolStripItem[] { novoServiçoToolStripMenuItem, checkOutToolStripMenuItem });
            MenuCheckInOut.Image = (Image)resources.GetObject("MenuCheckInOut.Image");
            MenuCheckInOut.Name = "MenuCheckInOut";
            MenuCheckInOut.Size = new Size(106, 20);
            MenuCheckInOut.Text = "Check In/Out";
            // 
            // novoServiçoToolStripMenuItem
            // 
            novoServiçoToolStripMenuItem.Image = (Image)resources.GetObject("novoServiçoToolStripMenuItem.Image");
            novoServiçoToolStripMenuItem.Name = "novoServiçoToolStripMenuItem";
            novoServiçoToolStripMenuItem.Size = new Size(130, 22);
            novoServiçoToolStripMenuItem.Text = "Check In";
            // 
            // checkOutToolStripMenuItem
            // 
            checkOutToolStripMenuItem.Image = (Image)resources.GetObject("checkOutToolStripMenuItem.Image");
            checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            checkOutToolStripMenuItem.Size = new Size(130, 22);
            checkOutToolStripMenuItem.Text = "Check Out";
            // 
            // MenuRelatorios
            // 
            MenuRelatorios.Image = (Image)resources.GetObject("MenuRelatorios.Image");
            MenuRelatorios.Name = "MenuRelatorios";
            MenuRelatorios.Size = new Size(87, 20);
            MenuRelatorios.Text = "Relatórios";
            // 
            // MenuSair
            // 
            MenuSair.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            MenuSair.Image = (Image)resources.GetObject("MenuSair.Image");
            MenuSair.Name = "MenuSair";
            MenuSair.Size = new Size(54, 20);
            MenuSair.Text = "Sair";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // TopPanel
            // 
            TopPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TopPanel.BackColor = SystemColors.AppWorkspace;
            TopPanel.Location = new Point(0, 27);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(594, 75);
            TopPanel.TabIndex = 1;
            // 
            // RightPanel
            // 
            RightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RightPanel.BackColor = SystemColors.ScrollBar;
            RightPanel.Controls.Add(label2);
            RightPanel.Controls.Add(label1);
            RightPanel.Location = new Point(600, 27);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(200, 411);
            RightPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 45);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 1;
            label2.Text = "Data:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 0;
            label1.Text = "Hora:";
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RightPanel);
            Controls.Add(TopPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "menuForm";
            Text = "Hotel";
            WindowState = FormWindowState.Maximized;
            Load += menuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuCadastro;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem hóspedesToolStripMenuItem;
        private ToolStripMenuItem quartosToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem serviçosToolStripMenuItem;
        private ToolStripMenuItem MenuProdutos;
        private ToolStripMenuItem novoProdutoToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem MenuMovimentacoes;
        private ToolStripMenuItem novaVendaToolStripMenuItem;
        private ToolStripMenuItem novoServiçoToolStripMenuItem1;
        private ToolStripMenuItem entradasESaídasToolStripMenuItem;
        private ToolStripMenuItem MenuReservas;
        private ToolStripMenuItem novaReservaToolStripMenuItem;
        private ToolStripMenuItem quadroDeReservasToolStripMenuItem;
        private ToolStripMenuItem consultarReservasToolStripMenuItem;
        private ToolStripMenuItem MenuCheckInOut;
        private ToolStripMenuItem novoServiçoToolStripMenuItem;
        private ToolStripMenuItem checkOutToolStripMenuItem;
        private ToolStripMenuItem MenuRelatorios;
        private ToolStripMenuItem MenuSair;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel TopPanel;
        private Panel RightPanel;
        private Label label2;
        private Label label1;
    }
}