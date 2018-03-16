Myapp\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -register:user -target:"MyApp\packages\xunit.runner.console.2.3.1\tools\net452\xunit.console.x86.exe" -targetargs:"MyApp\MyTests\bin\Debug\MyTests.dll -noshadow" -output:".\coverage.xml" -filter:"+[MyApp*]* -[MyTests*]*"

MyApp\packages\Codecov.1.0.3\tools\codecov.exe -f coverage.xml -t 92689bfe-74fc-417e-b4a0-bf231a0f901b