using DiplomWork.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DiplomWork
{
    public partial class ScheduleForm : Form
    {
        private Model1 model1 = new Model1();

        public ScheduleForm()
        {
            InitializeComponent();
            // Привязываем обработчик события загрузки формы
            this.Load += new EventHandler(ScheduleForm_Load);
        }

        private FlowLayoutPanel CreatePanel(int width, int height, int posX, int posY)
        {
            return new FlowLayoutPanel()
            {
                Size = new Size(width, height),
                Location = new Point(posX, posY),
                BorderStyle = BorderStyle.FixedSingle,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
        }

        private Label CreateLabel(string text)
        {
            return new Label()
            {
                Text = text,
                AutoSize = true
            };
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            int width = 200;
            int height = 100;
            int panelPosX = 10;
            int panelPosY = 10;
            int padding = 10;

            var workouts =  model1.Workout;

            foreach (var workout in workouts)
            {
                var panel = CreatePanel(width, height, panelPosX, panelPosY);

                var workoutLabel = CreateLabel("Workout: " + workout.Name);
                panel.Controls.Add(workoutLabel);

                // Получаем тренера по TrainerID
                var trainer = model1.Trainer.FirstOrDefault(t => t.TrainerID == workout.TrainerID);
                if (trainer != null)
                {
                    var trainerLabel = CreateLabel("Trainer: " + trainer.FirstName + " " + trainer.LastName);
                    panel.Controls.Add(trainerLabel);
                }

                this.Controls.Add(panel);

                // Изменяем позицию panelPosY после добавления панели
                panelPosY += panel.Height + padding;
            }
        }
    }
}
