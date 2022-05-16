package com.example.practwork32

import android.os.Bundle
import android.widget.TableRow
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.size
import androidx.compose.material.*
import androidx.compose.runtime.*
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.TextStyle
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import com.example.practwork32.ui.theme.PractWork32Theme
import androidx.compose.ui.unit.sp
import kotlinx.coroutines.delay
import kotlinx.coroutines.launch
import java.lang.reflect.Field

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            PractWork32Theme {
                // A surface container using the 'background' color from the theme
                Surface(
                    modifier = Modifier.fillMaxSize(),
                    color = MaterialTheme.colors.background
                ) {
                    //Greeting("ПКС-91")
                    //CounterScreen()
                    //AuthScreen()
                    TimerScreen()
                }
            }
        }
    }
}

@Composable
fun Greeting(name: String) {
    Text(text = "Привет $name!")
}

@Preview(showBackground = true)
@Composable
fun CounterScreen(){
    val taps = remember{mutableStateOf(0)}
    Text(text = "Количество нажатий: ${taps.value}",
        style = TextStyle(
            fontSize = 22.sp,
            color = Color.Magenta,
            background = Color.Green
        ),
        modifier = Modifier
            .padding(10.dp)
            .clickable(onClick = { taps.value = taps.value + 1 })
    )
}

@Preview(showBackground = true)
@Composable
fun AuthScreen(){
    var login = remember{mutableStateOf("")}
    var password = remember{mutableStateOf("")}
    var label = remember{mutableStateOf("")}
    Column{
        Text("Логин", fontSize = 30.sp)
        TextField(value = login.value, onValueChange = {newText -> login.value = newText})
        Text("Пароль", fontSize = 30.sp)
        TextField(value = password.value, onValueChange = {newText -> password.value = newText})
        Button(onClick = {label.value = "Вы авторизованы"}){
            Text("Авторизоваться", fontSize = 25.sp)
        }
        Li
        Text(text = label.value, fontSize = 30.sp, modifier = Modifier.padding(50.dp))
    }
}

@Preview(showBackground = true)
@Composable
fun TimerScreen(){
    var time by remember { mutableStateOf(60.0f) }
    var progress by remember { mutableStateOf(0.0f) }
    val scope = rememberCoroutineScope()

    Column(
        modifier = Modifier.padding(50.dp)
    ){
        Text("Статус: ${time}", fontSize = 22.sp)
        OutlinedButton(
            onClick = {
                time = 60.0f
                scope.launch {
                    while (time > 0f) {
                        time -= 1f
                        progress = time/60.0f
                        delay(1000L)
                    }
                }
            }
        ) {
            Text("Запустить", fontSize = 22.sp)
        }
        CircularProgressIndicator(progress = progress, modifier = Modifier.padding(10.dp).size(100.dp) )
    }
}

@Preview(showBackground = true)
@Composable
fun DefaultPreview() {
    PractWork32Theme {
        Greeting("ПКС-91")
    }
}