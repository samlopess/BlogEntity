using Blog_Entity.Data;
using Blog_Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext())
            {

            }
        }
    }
}