package project.test;

import org.testng.Assert;
import org.testng.annotations.Test;
import project.pageObject.KinopoiskHdPage;
import project.pageObject.MainPage;

public class TestCase9 extends Base {

    @Test
    public void testCase9() {
        MainPage mainPage = new MainPage();
        Assert.assertTrue(mainPage.IsMainPageOpened(),"Main page did not opened");
        mainPage.kinopoiskHd.click();
        KinopoiskHdPage kinopoiskHdPage = new KinopoiskHdPage();
        Assert.assertTrue(kinopoiskHdPage.kinopoiskHd.isDisplayed(),"KinopoiskHd page did not opened");
        kinopoiskHdPage.kinopoiskHd.hoverElement();
        kinopoiskHdPage.kinopoisk.click();
        Assert.assertTrue(mainPage.IsMainPageOpened(),"Main page did not opened");
    }
}
