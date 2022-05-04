@extends('layouts.app')

@section ('title-block')
Контакты
@endsection

@include('inc.header')

@section('content')
<?php
        function longdate($timestamp)
        {
            return date("l F jS Y", $timestamp);
        }
        echo longdate(time());
        ?>
  @include('inc.footer')      
@endsection
@section('footer')
  @include('inc.footer')      
@endsection
