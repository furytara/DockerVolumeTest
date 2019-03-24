$action = New-ScheduledTaskAction -Execute 'C:\Users\hongocdoanh\Documents\viblo\code\2\VibloDockerTest\VibloDockerTest\bin\Debug\VibloDockerTest.exe'
$trigger =  New-ScheduledTaskTrigger -Once -At 5:08pm -RepetitionInterval (New-TimeSpan -Minutes 1)
Register-ScheduledTask -Action $action -Trigger $trigger -TaskName "VibloTestAppLog" -Description "Log time each 60s"