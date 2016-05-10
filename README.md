
<h1>Memory Game </h1>

<p>
  Оваа семинарска работа ја опфаќа добро познатата игра Меморија. Меморијата е вештина која ја употребуваме секојдневно и што подобра е , толку подобро и за нас.  Целта на оваа игра е подобрување на меморијата. Процесот може да се направи многу лесно, со само неколку чекори и да се изведе без никаков напор. Многу е лесна за играње, во суштина толку е едноставна што и малите деца можат да ја играат со леснотија.  Единствено нешто кое се бара е набљудување, добра концентрација и добра меморија за да се победи. 
</p>

<p>Играта се состои од 3 форми. Главната форма е (Form1) е главното мени во кое постојат 3 опции: </p>
<ul>
<li><b> PLAY </b>– копче за почеток на играта</li>
<li><b> HOW TO PLAY</b> – копче за правила на играта</li>
<li> <b>EXIT</b> – копче за излез од играта</li>
</ul>
![alt text](https://github.com/IvanaJ/MemoryGame/blob/master/1.jpg)

<p>
Покрај овие опции во горниот десен алог се поставени две копчиња кои се поврзани со музиката во играта. Кога се стартува самата игра автоматски ни се пушта музика, доколку сакаме да ја исклучиме истата се клика на копчето за гасење на музиката. Доколку сакаме пак да ја вклучиме го кликаме копчето за вклучување на музиката.
Со клик на  копчето <b>Play</b>  се отвара нова форма <b>(MemoryGame)</b> каде е и всушност играта. Во оваа форма покрај самата игра во долниот дел се сместени освоените поени како и тајмерот. Доколку погодиме две исти полиња добиваме 20 поени, додека пак за секој утнат пар полиња се добиваат минус 5 поени. Времето пак за завршување на играта е 90 секунди. 

</p>
![alt text](https://github.com/IvanaJ/MemoryGame/blob/master/2.jpg)

<p>
Доколку не успееме да ги погодиме сите парови полиња за 90 секунди тогаш играта е завршена и ни се покажува прозорец со прашање (Дали сакате нова игра?). Доколку кликнеме на копчето <b>„Да“</b> тогаш ни се отвара нова игра со рандом наместени полиња, а ако стиснеме<b> „НЕ“ </b>тогаш ни се гаси играта. 
</p>

![alt text](https://github.com/IvanaJ/MemoryGame/blob/master/3.png)
<p>
Кога ќе успееме да ја завршиме играта за помалку од 90 секунди тогаш ни се појавува прозорец со овоените поени.
</p>
![alt text](https://github.com/IvanaJ/MemoryGame/blob/master/4.png)

<p>
Со клик на копчето<b> HOW TO PLAY</b> ни се оствара и последната форма во која е дадено упатството за играње на играта. Исто така во долниот десен агол има копче<b> BACK</b>за да можеме да се вратиме на главната форма. 
</p>
![alt text](https://github.com/IvanaJ/MemoryGame/blob/master/5.png)

<h3>Опис на изворниот код</h3>

<p> Функцијата <b>AssignIconsToSquares</b> се повикува веднаш штом се стартува играта и всушност со Random класата  од листата icons се додаваат иконите рандом на секоја лабела.  </p>
  ```c#
  private void AssignIconsToSquares()
        {
        
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                     iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
  ```
<p> Функцијата  <b>CalculateTotal</b> ја употребуваме за пресметка на поените кои сме ги освоиле. Доколку она поле што сме го кликнале прво е исто со второто тогаш добиваме 20 поени, во спротивно губиме 5 поени од освоените. За таа цел имаме една променлива sum која ни ги чува моменталните поени. </p>
```c#
private void CalculateTotal() {
            float pointsGuess = 20;
            float pointsWrong = - 5;
            
            if (firstClicked.Text == secondClicked.Text)
            {
                sum += pointsGuess;
            }
            if (firstClicked.Text != secondClicked.Text)
            {
                sum += pointsWrong;
            }
            tbPoints.Text = string.Format("{0:0.00}", sum);
  }
  ```


<p> <b>Timer2_Tick </b> ни кажува уште колку време ни е останато. Всушност времето се намалува за 1 секунда и кога тајмерот ќе биде 0 од класата SoundPlayer се вклучува соодетна песна. Користиме  вгнезден if отвараме MessageBox и доколку се одговори позитивно се отвара нова игра, во спротивно апликацијата се исклучува. </p>
```c#
private void timer2_Tick(object sender, EventArgs e)
        {
            time -= 1;
            label18.Text = "Time = " + time;
            if (time == 0)
            {
                SoundPlayer sound1 = new SoundPlayer(Properties.Resources.game_over);
                sound1.Play();
                if (MessageBox.Show("Дали сакате нова игра?", "Нова игра", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sound1.Stop();
                    MemoryGame newform = new MemoryGame();
                    this.Hide();
                    newform.ShowDialog();
                    
                }
                else
                    Application.Exit();
                label18.Text = "Game finished";
               
                this.Enabled = false;
            }
        }

```
<p> Оваа игра ќе ви  активира некои делови од мозокот кои се одговорни за стекнување меморија и ќе ви помогне да ја подобрите вашата меморија. Уживајте во неа и обидете се да ја завршите пред 90 секунди. </p>

<h4>Изработи: </h4>
Ивана Јакимовска 133022


