using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.JSON
{
    class JsonWorker
    {
        public static string ToJson(IEnumerable<MyProduct> products)
        {
            return JsonConvert.SerializeObject(products);
        }

        public static string ToJson(MyProduct product)
        {
            return JsonConvert.SerializeObject(product);
        }

        public static MyProduct ToMyProducts(string json)
        {
            return JsonConvert.DeserializeObject<MyProduct>(json);
        }

        public static List<MyProduct> ToMyProducts(string json, object o)
        {
            return JsonConvert.DeserializeObject<List<MyProduct>>(json);
        }
    }

    class MyProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
