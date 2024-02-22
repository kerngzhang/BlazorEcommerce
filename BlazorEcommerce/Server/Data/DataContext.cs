

namespace BlazorEcommerce.Server.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 1,
                    Title = "DOTNET",
                    Description = ".NET是一种用于构建多种应用的免费开源开发平台，可以使用C#、F#或Visual Basic编写.NET应用。 [10].NET用于生成多种类型的应用程序和库开发Web应用、Web API和微服务、云中的无服务器函数、云原生应用、移动应用、桌面应用、Windows WPF、Windows窗体、通用 Windows平台 (UWP)、游戏、物联网 (IoT)、机器学习、控制台应用、Windows服务。.NET类库在不同应用和应用类型中共享功能，无论构建哪种类型的应用，代码和项目文件看起来都一样，可以访问每个应用的相同运行时、API和语言功能",
                    //ImageUrl="https://bkimg.cdn.bcebos.com/pic/dc15484e06a52a45b2de05ef?x-bce-process=image/format,f_auto/watermark,image_d2F0ZXIvYmFpa2UyNzI,g_7,xp_5,yp_5,P_20/resize,m_lfit,limit_1,h_1080",
                    ImageUrl = @"https://ts1.cn.mm.bing.net/th/id/R-C.cc5dfaddc5c49eec3900490e1e97e2f4?rik=ExP1i6ccA46OQg&riu=http%3a%2f%2fpic.qqtn.com%2fup%2f2017-8%2f2017083009461224505.jpg&ehk=XgUQDp6KbJAJBGleeWml5cmqdYE7iL0vT8Bu%2fGfB3N8%3d&risl=&pid=ImgRaw&r=0&sres=1&sresct=1",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "JAVA",
                    Description = "Java是一门面向对象的编程语言，不仅吸收了C++语言的各种优点，还摒弃了C++里难以理解的多继承、指针等概念，因此Java语言具有功能强大和简单易用两个特征。Java语言作为静态面向对象编程语言的代表，极好地实现了面向对象理论，允许程序员以优雅的思维方式进行复杂的编程",
                    ImageUrl = @"https://ts1.cn.mm.bing.net/th/id/R-C.cc5dfaddc5c49eec3900490e1e97e2f4?rik=ExP1i6ccA46OQg&riu=http%3a%2f%2fpic.qqtn.com%2fup%2f2017-8%2f2017083009461224505.jpg&ehk=XgUQDp6KbJAJBGleeWml5cmqdYE7iL0vT8Bu%2fGfB3N8%3d&risl=&pid=ImgRaw&r=0&sres=1&sresct=1",

                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "PYTHON",
                    Description = "Python由荷兰国家数学与计算机科学研究中心的吉多·范罗苏姆于1990年代初设计，作为一门叫做ABC语言的替代品。 [1]Python提供了高效的高级数据结构，还能简单有效地面向对象编程。Python语法和动态类型，以及解释型语言的本质，使它成为多数平台上写脚本和快速开发应用的编程语言， [2]随着版本的不断更新和语言新功能的添加，逐渐被用于独立的、大型项目的开发",
                    ImageUrl = @"https://ts1.cn.mm.bing.net/th/id/R-C.cc5dfaddc5c49eec3900490e1e97e2f4?rik=ExP1i6ccA46OQg&riu=http%3a%2f%2fpic.qqtn.com%2fup%2f2017-8%2f2017083009461224505.jpg&ehk=XgUQDp6KbJAJBGleeWml5cmqdYE7iL0vT8Bu%2fGfB3N8%3d&risl=&pid=ImgRaw&r=0&sres=1&sresct=1",
                    Price = 6.99m
                });
        }
    }
}
