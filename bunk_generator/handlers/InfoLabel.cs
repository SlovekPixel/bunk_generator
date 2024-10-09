using System.Drawing;
using System.Windows.Forms;
using DotNetEnv;

namespace bunk_generator.handlers
{
    public class InfoLabel
    {
        public static (Panel, int, int) GetInfoLabel(Person person, int currentX, int currentY)
        {
            int maxHeightSize = Env.GetInt("MAX_FRAME_HEIGHT");
            int maxWidthSize = Env.GetInt("MAX_FRAME_WIDTH");
            int _PADDINGS = 5;
            
            int _FRAME_HEIGHT = maxHeightSize / 3 - _PADDINGS * 2;
            int _FRAME_WIDTH = maxWidthSize / 5 - _PADDINGS * 2;
            
            int _LABELHEIGHT = _FRAME_HEIGHT - _PADDINGS * 2;
            int _LABELWIDTH = _FRAME_WIDTH - _PADDINGS * 2;
            
            Panel squarePanel = new Panel();
            squarePanel.BackColor = Color.Beige;
            squarePanel.Size = new Size(_FRAME_WIDTH, _FRAME_HEIGHT);
            squarePanel.Location = new Point(currentX, currentY);

            Label infoLabel = new Label();
            infoLabel.Size = new Size(_LABELWIDTH, _LABELHEIGHT);
            infoLabel.Location = new Point(_PADDINGS, _PADDINGS);
            infoLabel.Text = person.ToString();
            infoLabel.TextAlign = ContentAlignment.TopLeft;
            infoLabel.BackColor = Color.White;
            infoLabel.BorderStyle = BorderStyle.FixedSingle;
            
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