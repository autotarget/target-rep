@extends('layouts.app')

@section ('title-block')
О нас
@endsection

@include('inc.header')


@section ('content')
<?php
        function longdate($timestamp)
        {
            return date("l F jS Y", $timestamp);
        }
        echo longdate(time());
        ?>
@endsection
<div>
@include('inc.footer') 
</div>

     
