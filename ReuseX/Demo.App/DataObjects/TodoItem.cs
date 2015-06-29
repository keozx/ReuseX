using Microsoft.Azure.Mobile.Server;

namespace Demo.App.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}