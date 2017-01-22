<?php
header("Content-type: text/html; charset=utf-8");
$error = 0; $msg = ""; $url = "";
if ($_FILES["imgFile"]["error"] > 0) {
    $error = 1;
    $msg   =  $_FILES["imgFile"]["error"];
} else {
    if (file_exists("upload/" . $_FILES["imgFile"]["name"])) {
        $error = 1;
        $msg   = $_FILES["imgFile"]["name"] . " already exists. ";
    } else {
        $filePath = "upload/" . $_FILES["imgFile"]["name"];
        move_uploaded_file($_FILES["imgFile"]["tmp_name"], $filePath);
        $url = $filePath;
    }
}
$results = "{\"error\" : \"". $error ."\",";
if ($error == 0) {
    $results += "\"url\" : \"". $url ."\"}";
} else {
    $results += "\"message\":\"". $msg ."\"}";
}
echo $results;
?>