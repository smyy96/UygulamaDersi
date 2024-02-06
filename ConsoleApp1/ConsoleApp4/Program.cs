using ConsoleApp4.Entities;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductRepository repo = new ProductRepository();


            repo.Add(new Product() { Id = 10, Name = "p10", Price = 10, StockAmount = 10 });


            var item =  repo.GetById(10);

            Console.WriteLine(item.Id);
            Console.WriteLine(item.Price);
            Console.WriteLine(item.Name);
            item.Price = 1000;
            item.Name = "p10 updated";

            repo.Update(item);

            
            Console.WriteLine("update sonrası");


            var updatedItem =  repo.GetById(10);

            Console.WriteLine(updatedItem.Id);
            Console.WriteLine(updatedItem.Price);
            Console.WriteLine(updatedItem.Name);




        }


    }


    public interface IEntity
    {
        public int Id { get; set; }
    }
    public interface IRepository<T> where T : IEntity
    {
        string FilePath { get; set; }
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);

        T GetById(int id);
    }


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


    public class ProductRepository : BaseRepo<Product>
    {
        public ProductRepository() : base(nameof(Product))
        {

        }

    }

}
