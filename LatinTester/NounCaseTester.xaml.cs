using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using CsharpUtils;
using LatinTester.Entities.Model;
using LatinTester.Entities.Nouns.Base;
using LatinTester.Enums;

namespace LatinTester
{
  public partial class NounCaseTester
  {
    private List<Button> _questions;
    private NounTestQuestion _question;
    private List<int> _answers;
    private List<int> _userAnswers;
    private const string SUBMIT_TEXT = "Submit";
    private const string NEXT_TEXT = "Next";
    private const string RESET_TEXT = "Reset";
    private const string EXIT_TEXT = "Exit";
    private readonly static Brush SELECTED_BRUSH = Brushes.CadetBlue;
    private static readonly Brush NOT_SELECTED_BRUSH = Brushes.White;

    public NounCaseTester()
    {
      InitializeComponent();
      InitializeQuestions();
    }

    public bool IsCorrect
    {
      get { return _answers.EquivalentTo(_userAnswers); }
    }

    private void InitializeQuestions()
    {
      SubmitButton.Content = SUBMIT_TEXT;
      CancelButton.Content = RESET_TEXT;
      _question = new NounTestQuestion();
      _answers = new List<int>();
      _userAnswers = new List<int>();
      Question.Text = string.Format("Which of the following are {0}", _question.Case.ToString().ToLower());
      _questions = new List<Button>();
      Case questionCase = _question.Case;
      for (int i = 0; i < 10; i ++)
      {
        Noun noun = _question.Nouns[i];
        Case nounCase = _question.Cases[i];
        string text = noun.Get(nounCase, RandomHelper.NextFairCoin ? Number.Singular : Number.Plural);
        if (text.IsOneOf(noun.Get(questionCase, Number.Singular), noun.Get(questionCase, Number.Plural)))
        {
          _answers.Add(i);
        }
        Button newTextBlock = GetNewTextBlockForQuestion(
          text,
          _question.Nouns[i].ToString(),
          (i / 2) * 30, // First division is integer division
          i % 2 == 0 ? HorizontalAlignment.Left : HorizontalAlignment.Right,
          i);
        _questions.Add(newTextBlock);
        Questions.Children.Add(newTextBlock);
      }
    }

    private Button GetNewTextBlockForQuestion(
      string text,
      string hint,
      int topMargin,
      HorizontalAlignment alignment,
      int questionIndex)
    {
      var ret = new Button
        {
          Width = 140,
          HorizontalAlignment = alignment,
          Margin = new Thickness(0, topMargin, 0, 0),
          VerticalAlignment = VerticalAlignment.Top,
          Content = text,
          ToolTip = hint,
          Background = NOT_SELECTED_BRUSH
        };
      ret.Click += (s, e) => ToggleQuestion(questionIndex);
      return ret;
    }

    private void ToggleQuestion(int questionIndex)
    {
      if (_userAnswers.Contains(questionIndex))
      {
        _userAnswers.Remove(questionIndex);
        _questions[questionIndex].Background = NOT_SELECTED_BRUSH;
      }
      else
      {
        _userAnswers.Add(questionIndex);
        _questions[questionIndex].Background = SELECTED_BRUSH;
      }
      Keyboard.Focus(SubmitButton);
    }

    public void SubmitButtonClick(object sender, RoutedEventArgs e)
    {
      if (SubmitButton.Content.ToString() == NEXT_TEXT)
      {
        Status.Text = string.Empty;
        InitializeQuestions();
        return;
      }
      if (IsCorrect)
      {
        Status.Text = "You got it right; well done!";
        SubmitButton.Content = NEXT_TEXT;
        CancelButton.Content = EXIT_TEXT;
        _questions.ForEach(q => q.IsEnabled = false);
        return;
      }
      Status.Text = string.Format(
        "You got {0} out of {1} correct.",
        _answers.Intersect(_userAnswers).Count(),
        _answers.Count);
    }

    public void CancelButtonClick(object sender, RoutedEventArgs e)
    {
      if (SubmitButton.Content.ToString() == NEXT_TEXT)
      {
        Close();
        return;
      }
      _questions.ForEach(q => q.Background = NOT_SELECTED_BRUSH);
      _userAnswers = new List<int>();
    }
  }
}
