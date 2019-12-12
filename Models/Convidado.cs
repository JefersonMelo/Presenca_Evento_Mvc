using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

    /* 
    Etapa 2:

    Faça um sistema simples em ASP.NET MVC usando a ideia implementada no protótipo do projeto console:
    Inclua uma página inicial de apresentação do sistema com título, texto informativo sobre a festa ao
    qual o convidado vai confirmar ou não a presença. Também inclua um link que direciona para a página
    de confirmação. Faça uma página de confirmação que conte com um formulário e os seguintes 
    campos: nome, idade, telefone e um checkbox para marcar se o usuário vai ou não à festa.
    Crie em Models classes baseadas nas classes “Convidado” e “ListaConvidados”, com as mesmas ações.
    A página de confirmação fará um post para uma ação no Controller. Crie essa ação, que deve incluir 
    na lista de convidados o objeto de “Convidado”, formado a partir das informações de formulário.
    Mostre, em seguida, uma página de confirmação ao usuário, dizendo “Resposta registrada com sucesso” 
    ou “Resposta não foi registrada” dependendo do retorno do método de inclusão de item na lista. Crie uma 
    página que faça a listagem, a partir da lista de “ListaConvidados” com todos os convidados registrados. 
    Usa uma tabela para mostrar os dados. O visual das páginas é livre.
    */
namespace Presenca_Evento_MVC.Models
{
    public class Convidado
    {
        //construtor vazio
        public Convidado() { }

        //attributos requeridos na classe convidado
        private string nome, telefone;
        private int idade;
        private bool confirmaPresenca;


        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Idade { get => idade; set => idade = value; }
        public bool ConfirmaPresenca { get => confirmaPresenca; set => confirmaPresenca = value; }

        //construtor com os atributos requeridos para esta atividade.
        public Convidado(string nome, string telefone, int idade, bool confirmaPresenca)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Idade = idade;
            this.ConfirmaPresenca = confirmaPresenca;
        }

    }
}