using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class HelloPlayModeTest
    {
        [SetUp]
        public void Init()
        {
            SceneManager.LoadScene("TestScene");
        }
        [TearDown]
        public void Finish()
        {
        }

        [UnityTest]
        public IEnumerator —Ž‰º()
        {
            var player = GameObject.Find("Player");
            var pos = player.transform.position;
            Assert.That(pos.y, Is.GreaterThan(0));

            yield return new WaitForSeconds(3);

            pos = player.transform.position;
            Assert.That(pos.y, Is.LessThan(0));
        }
    }
}


