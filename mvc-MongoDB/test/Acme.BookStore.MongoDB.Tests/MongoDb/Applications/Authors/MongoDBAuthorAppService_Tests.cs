using Acme.BookStore.MongoDB;
using Acme.BookStore.Authors;
using Xunit;

namespace Acme.BookStore.MongoDb.Applications.Authors;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class MongoDBAuthorAppService_Tests : AuthorAppService_Tests<BookStoreMongoDbTestModule>
{

}
