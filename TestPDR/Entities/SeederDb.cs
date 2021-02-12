using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPDR.Entities
{
    public class SeederDb
    {
        public static void Seed(EFContext eFContext)
        {
            SeedQuestion(eFContext);
        }
        private static void SeedQuestion(EFContext context)
        {
            if (context.Questions.Count() == 0)
            {
                var question = new Question
                {
                    Text = "Скільки планет в Сонячній системі?",
                };
                context.Questions.Add(question);
                context.SaveChanges();

                var answers = new List<Answer>
                {
                    new Answer { Text="8", IsTrue=true, QuestionId=question.Id },
                    new Answer { Text="9", IsTrue=false, QuestionId=question.Id },
                    new Answer { Text="10", IsTrue=false, QuestionId=question.Id }
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();

                question = new Question
                {
                    Text = "Яке небесне тіло було раніше планетою?",
                };
                context.Questions.Add(question);
                context.SaveChanges();

                answers = new List<Answer>
                {
                    new Answer { Text="Місяць", IsTrue=false, QuestionId=question.Id },
                    new Answer { Text="Плутон", IsTrue=true, QuestionId=question.Id },
                    new Answer { Text="Харон", IsTrue=false, QuestionId=question.Id },
                    new Answer { Text="Церера", IsTrue=false, QuestionId=question.Id }
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();

                question = new Question
                {
                    Text = "Що знаходиться між орбітами Марса та Юпітера?",
                };
                context.Questions.Add(question);
                context.SaveChanges();

                answers = new List<Answer>
                {
                    new Answer { Text="Пояс Койпера", IsTrue=false, QuestionId=question.Id },
                    new Answer { Text="Пояс астероїдів", IsTrue=true, QuestionId=question.Id },
                    new Answer { Text="Кільця Сатурна", IsTrue=false, QuestionId=question.Id }
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();

                question = new Question
                {
                    Text = "Скільки супутників у Юпітера?",
                };
                context.Questions.Add(question);
                context.SaveChanges();

                answers = new List<Answer>
                {
                    new Answer { Text="13", IsTrue=false, QuestionId=question.Id },
                    new Answer { Text="47", IsTrue=false, QuestionId=question.Id },
                    new Answer { Text="79", IsTrue=true, QuestionId=question.Id },
                    new Answer { Text="97", IsTrue=false, QuestionId=question.Id }
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();

                question = new Question
                {
                    Text = "Яка ще гіпотетична планета обертається навколо Сонця?",
                };
                context.Questions.Add(question);
                context.SaveChanges();

                answers = new List<Answer>
                {
                    new Answer { Text="Тіамат", IsTrue=false, QuestionId=question.Id },
                    new Answer { Text="Фаетон", IsTrue=false, QuestionId=question.Id },
                    new Answer { Text="Нібіру", IsTrue=true, QuestionId=question.Id }
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
            }

        }
    }
}
