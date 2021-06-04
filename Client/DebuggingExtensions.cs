using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PizzaStore.Client
{
    public static class DebuggingExtensions
    {
        public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, obj.GetType());
    }
}
