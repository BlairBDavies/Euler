#Limit the number to download
$maxProblem = 30
$mostRecentProblem = FindRecent

$currentBatch = 1
foreach($problem in 1..($mostRecentProblem)) {
    if ($problem -gt $maxProblem) {
        break
    }
    if (Test-Path $("Euler\**\Problem$problem.cs"))
    {
        continue
    }

    write-host "Creating $problem"
    
    $folderName = "Problems $($currentBatch) to $($currentBatch+19)"
    
    new-item -Name $folderName -ItemType Directory -Path Euler -ErrorAction SilentlyContinue | Out-Null
    new-item -Name $folderName -ItemType Directory -Path Test -ErrorAction SilentlyContinue | Out-Null

    $class = new-item -ItemType File -Name "$folderName\Problem$problem.cs" -Path Euler
    $unitTest = new-item -ItemType File -Name "$folderName\UnitTest$problem.cs" -Path Test
    @"
using System;
using System.Linq;

namespace Euler
{
    public class Problem$problem
    {
        /* 
        
        https://projecteuler.net/problem=$problem

        */

    }
}

"@ | out-file $class
@"
using NUnit.Framework;
using Euler;

namespace Test
{
    public class UnitTest$problem
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProblem$problem()
        {
            Asser.Pass();
        }
    }
}

"@ | out-file $unitTest


    if ($problem % 20 -eq 0) {
        $currentBatch += 20
    }
}


function FindRecent{    
    $page = Invoke-WebRequest -Uri https://projecteuler.net/recent -Method Get -UseBasicParsing
    $result = $page.Content -match '<td class="id_column">(.*?)</td>'
    if ($result) {
        return $matches[1].ToInt32($null)
        }
        return 0
}
