using AutoMapper;
using System.Reflection;
using System.Text.Json;
using zTempo.Persistence.Entity;



namespace zTempo.Persistence.SeedWork
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly string fileName = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\db.json";
        private readonly JsonSerializerOptions jsonOptions;
        private EntityRoot entityRoot;

        public Repository()
        {
            jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            if (!File.Exists(fileName))
            {
                string jsonString = JsonSerializer.Serialize(new EntityRoot(), jsonOptions);
                File.WriteAllText(fileName, jsonString); ;
            }
            entityRoot = JsonSerializer.Deserialize<EntityRoot>(File.ReadAllText(fileName));
        }

        public List<T> GetList()
        {
            entityRoot = JsonSerializer.Deserialize<EntityRoot>(File.ReadAllText(fileName));
            var typesGeneric = GetType().BaseType.GenericTypeArguments;
            if (typesGeneric.Length == 0) return null;
            var result = entityRoot.GetType().GetProperty($"{typesGeneric[0].Name}s").GetValue(entityRoot);
            return (List<T>)result;
        }

        public void SaveChanges(List<T> entity)
        {
            var typeSource = entity.FirstOrDefault();
            if (typeSource == null) return;
            entityRoot = JsonSerializer.Deserialize<EntityRoot>(File.ReadAllText(fileName));
            entityRoot.GetType().GetProperty($"{typeSource.GetType().Name}s").SetValue(entityRoot,  entity);
            string jsonString = JsonSerializer.Serialize(entityRoot, jsonOptions);
            File.WriteAllText(fileName, jsonString);
        }
    }
}