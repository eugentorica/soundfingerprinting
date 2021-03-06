namespace Soundfingerprinting.Dao.Internal
{
    using System;
    using System.Data;

    using Soundfingerprinting.Dao.Conditions;

    public interface IParameterBinder
    {
        IParameterBinder WithParameter(string name, string value);

        IParameterBinder WithParameter(string name, int value);

        IParameterBinder WithParameter<T>(string name, T value) where T : struct;

        IParameterBinder WithParameter(string name, DateTime value);

        IParameterBinder WithParametersFromModel<TModel>(TModel model, params ICondition<TModel>[] conditions) where TModel : new();

        void WithParameter(string name, DbType type, object value);

        IExecutor Execute();
    }
}