using Class03.NotesAndTagsApp.Models;
using Class03.NotesAndTagsApp.Models.Enums;

namespace Class03.NotesAndTagsApp.Data
{
    public class StaticDb
    {
        public static List<Note> Notes { get; set; } = new List<Note>()
    {
        new Note()
        {
            Text = "Do homework",
            Priority = Models.Enums.Priority.High,
            Tags = new List<Tag>()
            {
                new Tag() { Name = "Homework", Color = "red" },
                new Tag() { Name = "Avenga", Color = "blue" }
            }
        },
        new Note()
        {
            Text = "Drink more water",
            Priority = Priority.Medium,
            Tags = new List<Tag>()
            {
                new Tag() { Name = "Healthy", Color = "orange" },
                new Tag() { Name = "Priority High", Color = "blue" }
            }
        },
        new Note()
        {
            Text = "Go to the gym",
            Priority = Priority.Low,
            Tags = new List<Tag>()
            {
                new Tag() { Name = "Exercise", Color = "blue" },
                new Tag() { Name = "Priority Low", Color = "yellow" }
            }
        }
    };
    }
}
