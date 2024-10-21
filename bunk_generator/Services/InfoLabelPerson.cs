using System.Drawing;
using System.Windows.Forms;


namespace bunk_generator.Services
{
    public class InfoLabelPerson
    {
        public static (Panel, int, int) GetLabel(Person person, int currentX, int currentY)
        {
            int maxHeightSize = 680;
            int maxWidthSize = 920;
            int _PADDINGS = 10;
            
            int _FRAME_HEIGHT = maxHeightSize / 3 - _PADDINGS * 2;
            int _FRAME_WIDTH = maxWidthSize / 5 - _PADDINGS * 2;
            
            int _LABELHEIGHT = _FRAME_HEIGHT - _PADDINGS * 2;
            int _LABELWIDTH = _FRAME_WIDTH - _PADDINGS * 2;

            Label infoLabel = new Label();
            infoLabel.Size = new Size(_LABELWIDTH, _LABELHEIGHT);
            infoLabel.Location = new Point(_PADDINGS, _PADDINGS);
            infoLabel.Text = person.ToString();
            infoLabel.TextAlign = ContentAlignment.TopLeft;
            infoLabel.BackColor = Color.FromArgb(240, 240, 240);
            infoLabel.BorderStyle = BorderStyle.FixedSingle;
            infoLabel.Font = new Font("Arial", 7);

            Panel squarePanel = new Panel();
            squarePanel.BackColor = Color.FromArgb(220, 235, 255);
            squarePanel.Size = new Size(_FRAME_WIDTH, _FRAME_HEIGHT);
            squarePanel.Location = new Point(currentX, currentY + 20);
            squarePanel.Controls.Add(infoLabel);
            squarePanel.Tag = person;
            
            currentX += _FRAME_WIDTH + _PADDINGS;

            if (currentX + _FRAME_WIDTH > maxWidthSize)
            {
                currentX = _PADDINGS;
                currentY += _FRAME_HEIGHT + _PADDINGS;
            }

            return (squarePanel, currentX, currentY);
        }
    }
}