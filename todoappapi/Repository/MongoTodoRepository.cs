using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using todoappapi.Entity;

namespace todoappapi.Repository
{
    public class MongoTodoRepository : ITodoRepository
    {
        private const string databaseName = "todoapp";
        private const string collectionName = "todos";
        private readonly IMongoCollection<Todo> todoCollection;
        private readonly FilterDefinitionBuilder<Todo> filterBuilder = Builders<Todo>.Filter;

        public MongoTodoRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            todoCollection = database.GetCollection<Todo>(collectionName);
        }


        public void AddTodo(Todo todo)
        {
            todoCollection.InsertOne(todo);
        }

        public void DeleteTodo(int id)
        {
            var todo = filterBuilder.Eq(item => item.id, id);

            todoCollection.DeleteOne(todo);
        }

        public Todo GetTodo(int id)
        {
            var todo = filterBuilder.Eq(todo => todo.id, id);
            return todoCollection.Find(todo).SingleOrDefault();
        }

        public IEnumerable<Todo> GetTodos()
        {
            return todoCollection.Find(new BsonDocument()).ToList();
        }

        public void UpdateTodo(Todo todo)
        {
            var existingTodo = filterBuilder.Eq(item => item.id, todo.id);

            todoCollection.ReplaceOne(existingTodo, todo);
        }
    }
}
