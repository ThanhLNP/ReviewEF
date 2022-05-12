using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

namespace ReviewEF.Shared.Sql
{
    /// <summary>
    /// Example: [SqlDefaultValue("getutcdate()")]
    /// </summary>
    public static class SqlDefaultValueAttributeConvention
    {
        public static void Apply(ModelBuilder builder)
        {
            ConventionBehaviors
                .SetSqlValueForPropertiesWithAttribute<SqlDefaultValueAttribute>(builder, x => x.DefaultValue);
        }
    }

    /// <summary>
    /// Example: [DecimalPrecision(18, 9)]
    /// </summary>
    public static class DecimalPrecisionAttributeConvention
    {
        public static void Apply(ModelBuilder builder)
        {
            ConventionBehaviors
                .SetTypeForPropertiesWithAttribute<DecimalPrecisionAttribute>(builder,
                    x => $"decimal({x.Precision}, {x.Scale})");
        }
    }

    /// <summary>
    /// Example: [DataType("decimal(18,9)")]
    /// </summary>
    public class CustomDataTypeAttributeConvention
    {
        public static void Apply(ModelBuilder builder)
        {
            ConventionBehaviors
                .SetTypeForPropertiesWithAttribute<DataTypeAttribute>(builder,
                    x => x.CustomDataType);
        }
    }

    public static class ConventionBehaviors
    {
        public static void SetTypeForPropertiesWithAttribute<TAttribute>(ModelBuilder builder, Func<TAttribute, string> lambda) where TAttribute : class
        {
            SetPropertyValue<TAttribute>(builder).ForEach((x) =>
            {
                x.Item1.SetColumnType(lambda(x.Item2));
            });
        }

        public static void SetSqlValueForPropertiesWithAttribute<TAttribute>(ModelBuilder builder, Func<TAttribute, string> lambda) where TAttribute : class
        {
            SetPropertyValue<TAttribute>(builder).ForEach((x) =>
            {
                x.Item1.SetDefaultValueSql(lambda(x.Item2));
            });
        }

        private static List<Tuple<IMutableProperty, TAttribute>> SetPropertyValue<TAttribute>(ModelBuilder builder) where TAttribute : class
        {
            var propsToModify = new List<Tuple<IMutableProperty, TAttribute>>();
            foreach (var entity in builder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties();
                foreach (var property in properties)
                {
                    if (property.PropertyInfo?
                     .GetCustomAttributes(typeof(TAttribute), false)
                     .FirstOrDefault() is TAttribute attribute)
                    {
                        propsToModify.Add(new Tuple<IMutableProperty, TAttribute>(property, attribute));
                    }
                }
            }
            return propsToModify;
        }
    }
}
