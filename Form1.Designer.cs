namespace AgendaSQL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_AddTarefa = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.listaTarefas = new System.Windows.Forms.ListView();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_AddTarefa
            // 
            this.txtBox_AddTarefa.Location = new System.Drawing.Point(12, 12);
            this.txtBox_AddTarefa.Multiline = true;
            this.txtBox_AddTarefa.Name = "txtBox_AddTarefa";
            this.txtBox_AddTarefa.Size = new System.Drawing.Size(776, 52);
            this.txtBox_AddTarefa.TabIndex = 0;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(12, 83);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(581, 36);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // listaTarefas
            // 
            this.listaTarefas.HideSelection = false;
            this.listaTarefas.Location = new System.Drawing.Point(12, 139);
            this.listaTarefas.Name = "listaTarefas";
            this.listaTarefas.Size = new System.Drawing.Size(776, 299);
            this.listaTarefas.TabIndex = 2;
            this.listaTarefas.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(599, 83);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(94, 36);
            this.btn_Excluir.TabIndex = 3;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(699, 83);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(89, 36);
            this.btn_Atualizar.TabIndex = 4;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.listaTarefas);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txtBox_AddTarefa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_AddTarefa;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.ListView listaTarefas;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Atualizar;
    }
}

