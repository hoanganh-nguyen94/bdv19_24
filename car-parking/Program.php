<?php
$myfile = fopen("output.txt", "w") or die("Unable to open file!");
$txt = "hello the world";
fwrite($myfile, $txt);
fclose($myfile);
?>
