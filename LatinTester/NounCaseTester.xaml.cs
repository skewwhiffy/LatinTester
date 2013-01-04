using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using LatinTester.Entity;
using LatinTester.Enums;

namespace LatinTester
{
  public partial class NounCaseTester
  {
    private List<TextBlock> _questions;
    private NounTestQuestion _question;

    public NounCaseTester()
    {
      InitializeComponent();
      InitializeQuestions();
    }

    private void InitializeQuestions()
    {
      _question = new NounTestQuestion();
      Question.Text = string.Format("Which of the following is {0}", _question.Case);
      _questions = new List<TextBlock>();
      for (int i = 0; i < 10; i ++)
      {
        TextBlock newTextBlock = GetNewTextBlock(
          _question.Nouns[i].Get(_question.Cases[i], Number.Singular), // QQ Plural
          (i / 2) * 12, // First division is integer division
          i % 2 == 0 ? HorizontalAlignment.Left : HorizontalAlignment.Right);
        _questions.Add(newTextBlock);
        Questions.Children.Add(newTextBlock);
      }
    }

    private TextBlock GetNewTextBlock(string text, int topMargin, HorizontalAlignment alignment)
    {
      return new TextBlock
        {
          Width = 140,
          HorizontalAlignment = alignment,
          Margin = new Thickness(0, topMargin, 0, 0),
          TextWrapping = TextWrapping.Wrap,
          VerticalAlignment = VerticalAlignment.Top,
          Text = text
        };
    }

    // <TextBlock Width="140" HorizontalAlignment="Left" Margin="0,12,0,0" TextWrapping="Wrap" VerticalAlignment="Top"/>
  }
}
