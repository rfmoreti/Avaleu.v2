using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Avaleu.Services
{
	public interface IGenericService<TEntity>
	{
		TEntity Alterar(TEntity model);
		TEntity BuscarPorCodigo(int codigo);
		bool Excluir(int codigo);
		bool Excluir(TEntity model);
		TEntity Inserir(TEntity model);
		IList<TEntity> Listar();
		IList<TEntity> Listar(Expression<Func<TEntity, bool>> filtro);
	}
}