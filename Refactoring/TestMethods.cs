namespace Refactoring;

public class TestMethods
{
    // [SetUp]
    public void SetUp()
    {
        OpenChromeBrowser();
        DefaultSearch("Landing page suitable for the test", "Random keyword that leads to default behavior");
    }

    // [TearDown]
    public void TearDown()
    {
        CloseTheBrowser();
    }
    
    // [Test]
    public void NavigationTest()
    {
        OpenFirstLink();
    }

    // [Test]
    public void PlayTheFirstVideoTest()
    {
        PlayTheFirstVideo();
    }

    // [Test]
    public void CountTheResultsTest()
    {
        CountTheResults();
    }

    private void DefaultSearch(string url, string keyword)
    {
        NavigateToUrl(url);
        SearchTheWord(keyword);
    }

    private void CloseTheBrowser()
    {
        throw new NotImplementedException();
    }

    private void OpenFirstLink()
    {
        throw new NotImplementedException();
    }

    private void SearchTheWord(string keyword)
    {
        throw new NotImplementedException();
    }

    private void NavigateToUrl(string url)
    {
        throw new NotImplementedException();
    }

    private void OpenChromeBrowser()
    {
        throw new NotImplementedException();
    }
    
    private void CountTheResults()
    {
        throw new NotImplementedException();
    }
    
    private void PlayTheFirstVideo()
    {
        throw new NotImplementedException();
    }
}