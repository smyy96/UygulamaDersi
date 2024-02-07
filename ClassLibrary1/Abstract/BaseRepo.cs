using System.Text.Json;

namespace ClassLibrary1.Abstract
{
    public abstract class BaseRepo<T> : IRepository<T> where T : class, IEntity
    {
        protected List<T> DataSet = new List<T>();


        public BaseRepo(string name)
        {
            var filePath = name + ".json";

            if (File.Exists(filePath))
            {
                var jsonData = File.ReadAllText(filePath);
                if (jsonData != string.Empty)
                {
                    DataSet = JsonSerializer.Deserialize<List<T>>(jsonData);

                }
            }
            else
            {
                using (File.Create(filePath))
                {

                }
            }

            this.FilePath = filePath;
        }


        public string FilePath { get; set; }

        public void Add(T entity)
        {
            // var oldData = FileRead();
            //oldData.Add(entity);
            //DataSet = oldData;
            DataSet.Add(entity);
            FileWrite(DataSet);

        }

        public void Delete(int id)
        {

            foreach (var item in DataSet)
            {
                if (item.Id == id)
                {
                    DataSet.Remove(item);
                    FileWrite(DataSet);
                    return;
                }
            }
        }

        public List<T> GetAll()
        {
            return FileRead();
        }

        public void Update(T entity)
        {
            foreach (var item in DataSet)
            {
                if (item.Id == entity.Id)
                {
                    DataSet.Remove(item);
                    DataSet.Add(entity);
                    FileWrite(DataSet);
                    return;
                }
            }
        }



        protected void FileWrite(List<T> data)
        {
            File.WriteAllText(FilePath, JsonSerializer.Serialize(data));
        }
        protected List<T> FileRead()
        {
            if (File.ReadAllText(FilePath) != string.Empty)
            {

                return JsonSerializer.Deserialize<List<T>>(File.ReadAllText(FilePath));
            }
            return DataSet;
        }

        public T GetById(int id)
        {
            var data = GetAll();

            if (data.Count == 0)
            {
                return null;
            }
            foreach (var item in data)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
