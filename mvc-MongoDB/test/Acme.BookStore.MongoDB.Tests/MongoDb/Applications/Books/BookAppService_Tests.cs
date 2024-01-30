using Acme.BookStore.MongoDB;
using Acme.BookStore.Books;
using Xunit;

namespace Acme.BookStore.MongoDb.Applications.Books;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class MongoDBBookAppService_Tests : BookAppService_Tests<BookStoreMongoDbTestModule>
{

}
