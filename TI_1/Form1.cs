using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_1
{
  public partial class Form1 : Form
  {

    struct Fence_Element
    {
      public char symbol;
      public int index;
    }
    char[] letters;

    bool encrypt = true;
    bool fence = true;
    string sourceText = null;
    string resultText = null;
    string key = "";

    public Form1()
    {
      InitializeComponent();
      groupBox_RailFence.Enabled = false;
      groupBox_Vizhiner.Enabled = false;
      openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
      saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
      char c = 'а';
      letters = new char[33];
      for (int i = 0; i < 33; i++)
      {
        letters[i] = c;
        if (c == 'ё')
        {
          c = 'ж';
          continue;
        }
        c++;
        if (c == 'ж')
        {
          c = 'ё';
        }
      }
    }

    private void button_Close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private string remove_Wrong_Letters(string s, char a, char z)
    {
      s = s.ToLower();
      int i = 0;
      while (i < s.Length)
      {
        if (!(s[i] >= a && s[i] <= z))
        {
          s = s.Remove(i, 1);
        }
        else
        {
          i++;
        }
      }

      return s;
    }

    private string remove_Wrong_Letters_V(string s, char a, char z, char e)
    {
      s = s.ToLower();
      int i = 0;
      while (i < s.Length)
      {
        if (!((s[i] >= a && s[i] <= z) || s[i] == e))
        {
          s = s.Remove(i, 1);
        }
        else
        {
          i++;
        }
      }

      return s;
    }

    private string Fence_Encrypt(string plainText, int key)
    {
      if (key == 1)
      {
        return plainText;
      }
      Fence_Element[] fence_Elements = new Fence_Element[plainText.Length];
      Fence_Element e;
      string cipherText = "";
      int index = 1;
      int inc = 1;

      for (int i = 0; i < plainText.Length; i++)
      {
        e.symbol = plainText[i];
        e.index = index;
        fence_Elements[i] = e;

        index += inc;
        if (index == key || index == 1)
        {
          inc = -inc;
        }
      }

      index = 1;

      for (int k = 0; k < key; k++)
      {
        for (int i = 0; i < plainText.Length; i++)
        {
          if (index == fence_Elements[i].index)
          {
            cipherText += fence_Elements[i].symbol;
          }
        }
        index++;
      }

      return cipherText;
    }

    private string Fence_Decrypt(string cipherText, int key)
    {
      if (key == 1)
      {
        return cipherText;
      }
      Fence_Element[] fence_Elements = new Fence_Element[cipherText.Length];
      Fence_Element e;
      string plainText = "";
      int index = 1;
      int inc_cipherIndex = 1;

      for (int i = 0; i < cipherText.Length; i++)
      {
        e.symbol = ' ';
        e.index = index;
        fence_Elements[i] = e;

        index += inc_cipherIndex;
        if (index == key || index == 1)
        {
          inc_cipherIndex = -inc_cipherIndex;
        }
      }

      index = 1;
      inc_cipherIndex = 0;

      for (int k = 0; k < key; k++)
      {
        for (int i = 0; i < cipherText.Length; i++)
        {
          if (index == fence_Elements[i].index)
          {
            fence_Elements[i].symbol = cipherText[inc_cipherIndex];
            inc_cipherIndex++;
          }
        }
        index++;
      }

      for (int i = 0; i < cipherText.Length; i++)
      {
        plainText += fence_Elements[i].symbol;
      }

      return plainText;
    }

    private string Vizhener_Encrypt(string plainText, string key)
    {
      string cipherText = "";
      int keyI = 0;
      int i1, i2;

      for (int i = 0; i < plainText.Length; i++)
      {
        i1 = 0;
        while (plainText[i] != letters[i1])
        {
          i1++;
        }
        i2 = 0;
        while (key[keyI] != letters[i2])
        {
          i2++;
        }

        cipherText += letters[(i1 + i2) % letters.Length];
        keyI++;
        if (keyI == key.Length)
        {
          keyI = 0;
        }
      }

      return cipherText;
    }
    private string Vizhener_Decrypt(string cipherText, string key)
    {
      string plainText = "";
      int keyI = 0;
      int i1, i2;

      for (int i = 0; i < cipherText.Length; i++)
      {
        i1 = 0;
        while (cipherText[i] != letters[i1])
        {
          i1++;
        }
        i2 = 0;
        while (key[keyI] != letters[i2])
        {
          i2++;
        }
        plainText += letters[(i1 - i2 + letters.Length) % letters.Length];
        keyI++;
        if (keyI == key.Length)
        {
          keyI = 0;
        }
      }

      return plainText;
    }

    private void button_EncrRail_Click(object sender, EventArgs e)
    {
      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      if (textBox_Key.Text.Trim() == "")
      {
        MessageBox.Show("Не введен ключ для шифрования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      key = textBox_Key.Text;
      // получаем выбранный файл
      string filename = openFileDialog.FileName;
      textBox_IshFRail.Text = filename;
      // читаем файл в строку
      sourceText = System.IO.File.ReadAllText(filename);
      textBox_IshTxtRail.Text = sourceText;
      sourceText = remove_Wrong_Letters(sourceText, 'a', 'z');
      if (sourceText.Length == 0)
      {
        MessageBox.Show("Файл не содержит заданных символов");
        return;
      }
      key = remove_Wrong_Letters(key, '0', '9');
      if (key.Length == 0)
      {
        MessageBox.Show("Ключ не содержит заданных символов");
        return;
      }
      int fence_key;
      if (!Int32.TryParse(key, out fence_key) || fence_key < 1)
      {
        MessageBox.Show("Ключ некорректный");
        return;
      }
      resultText = Fence_Encrypt(sourceText, Convert.ToInt32(key));
      StreamWriter sw = new StreamWriter("C:\\Users\\Катя\\Desktop\\Тренировка языка Си\\Экзамен\\TI_1\\TI_1\\bin\\Debug\\EncrFile.txt");
      sw.Write(resultText);
      sw.Close();
      textBox_EncrRail.Text = resultText;
    }

    private void radioButton_RailFence_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton radioButton = (RadioButton)sender;
      if (radioButton.Checked)
      {
        groupBox_RailFence.Enabled = true;
        groupBox_Vizhiner.Enabled = false;
      }
    }

    private void radioButton_Vizhiner_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton radioButton = (RadioButton)sender;
      if (radioButton.Checked)
      {
        groupBox_Vizhiner.Enabled = true;
        groupBox_RailFence.Enabled = false;
      }
    }

    private void button_DecrRail_Click(object sender, EventArgs e)
    {
      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      // получаем выбранный файл
      string filename = openFileDialog.FileName;
      textBox_NameDecrRail.Text = filename;
      // читаем файл в строку
      sourceText = System.IO.File.ReadAllText(filename);
      key = textBox_Key.Text;
      key = remove_Wrong_Letters(key, '0', '9');
      sourceText = remove_Wrong_Letters(sourceText, 'a', 'z');
      resultText = Fence_Decrypt(sourceText, Convert.ToInt32(key));
      textBox_DecrRail.Text = resultText;
      StreamWriter sw = new StreamWriter("C:\\Users\\Катя\\Desktop\\Тренировка языка Си\\Экзамен\\TI_1\\TI_1\\bin\\Debug\\DecrFile.txt");
      sw.Write(resultText);
      sw.Close();
    }

    private void button_EncrVizh_Click(object sender, EventArgs e)
    {
      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      if (textBox_Key.Text.Trim() == "")
      {
        MessageBox.Show("Не введен ключ для шифрования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      key = textBox_Key.Text;
      // получаем выбранный файл
      string filename = openFileDialog.FileName;
      textBox_VFName.Text = filename;
      // читаем файл в строку
      sourceText = System.IO.File.ReadAllText(filename);
      textBox_VIshTxt.Text = sourceText;
      sourceText = remove_Wrong_Letters_V(sourceText, 'а', 'я', 'ё');
      if (sourceText.Length == 0)
      {
        MessageBox.Show("Файл не содержит заданных символов");
        return;
      }
      key = remove_Wrong_Letters_V(key, 'а', 'я', 'ё');
      if (key.Length == 0)
      {
        MessageBox.Show("Ключ не содержит заданных символов");
        return;
      }
      resultText = Vizhener_Encrypt(sourceText, key);
      StreamWriter sw = new StreamWriter("C:\\Users\\Катя\\Desktop\\Тренировка языка Си\\Экзамен\\TI_1\\TI_1\\bin\\Debug\\EncrFile.txt");
      sw.Write(resultText);
      sw.Close();
      textBox_EncrVizh.Text = resultText;
    }

    private void button_DecrVizh_Click(object sender, EventArgs e)
    {
      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      // получаем выбранный файл
      string filename = openFileDialog.FileName;
      textBox_VizhDecr.Text = filename;
      // читаем файл в строку
      sourceText = System.IO.File.ReadAllText(filename);
      key = textBox_Key.Text;
      key = remove_Wrong_Letters_V(key, 'а', 'я', 'ё');
      sourceText = remove_Wrong_Letters_V(sourceText, 'а', 'я', 'ё');
      resultText = Vizhener_Decrypt(sourceText, key);
      textBox_DecrTxtV.Text = resultText;
      StreamWriter sw = new StreamWriter("C:\\Users\\Катя\\Desktop\\Тренировка языка Си\\Экзамен\\TI_1\\TI_1\\bin\\Debug\\DecrFile.txt");
      sw.Write(resultText);
      sw.Close();
    }

    private void button_Clear_Click(object sender, EventArgs e)
    {
      textBox_DecrRail.Text = "";
      textBox_DecrTxtV.Text = "";
      textBox_EncrRail.Text = "";
      textBox_EncrVizh.Text = "";
      textBox_IshFRail.Text = "";
      textBox_IshTxtRail.Text = "";
      textBox_Key.Text = "";
      textBox_NameDecrRail.Text = "";
      textBox_VFName.Text = "";
      textBox_VIshTxt.Text = "";
      textBox_VizhDecr.Text = "";
    }
  }
}
