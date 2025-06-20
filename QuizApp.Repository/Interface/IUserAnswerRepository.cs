using QuizApp.Domain.DataModels;

namespace QuizApp.Repository.Interface;

public interface IUserAnswerRepository
{
    Task SaveAnswerAsync(Useranswer answer);

}
