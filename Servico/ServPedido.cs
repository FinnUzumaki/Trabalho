﻿using Trabalho.Dominio;
using Trabalho.Repositorio;

namespace Trabalho.Servico
{
    public static class ServPedido
    {
        public static List<Pedido> Browse(Fisica? pessoa = null)
        {
            return RepoPedido.ReadAll(pessoa);
        }
        public static Pedido? Read(long id)
        {
            return RepoPedido.Read(id);
        }
        public static Pedido? Edit(long id, Pedido instancia)
        {
            return RepoPedido.Update(id, instancia);
        }
        public static Pedido Add(Fisica pessoa, Pedido instancia)
        {
            return RepoPedido.Create(pessoa, instancia);
        }
        public static Pedido? Delete(long id)
        {
            return RepoPedido.Delete(id);
        }
    }
}