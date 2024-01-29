using MongoDB.Driver;
using TodoAppEntities;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace TodoApp.Data;

[ConnectionStringName("Default")]
public class TodoAppDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */
    public IMongoCollection<TodoItem> TodoItems => Collection<TodoItem>();

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.Entity<TodoItem>(b =>
        {
            b.CollectionName = "TodoItems";
        });

    }
}
