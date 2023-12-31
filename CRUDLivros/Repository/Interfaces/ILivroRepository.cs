﻿using CRUDLivros.Models;

namespace CRUDLivros.Repository.Interfaces
{
    public interface ILivroRepository
    {
        void AddLivro(LivroModel livro);
        List<LivroModel> GetLivros();
        void ExcluirLivro(int id);
        LivroModel BuscarPorId(int id);
        void ConfirmarEdicao(LivroModel livro);

    }
}
