Ñ	
aC:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\Context\ApplicationDbContext.cs
	namespace 	
TemizKodunOnemi
 
. 
AdvancedOrnek '
.' (
WebApi( .
.. /
Context/ 6
;6 7
public 
class  
ApplicationDbContext !
{ 
public 

void 
Add 
( 
Item 
item 
) 
{ 
}

 
public 

void 
SaveChanges 
( 
) 
{ 
} 
public 

List 
< 
Item 
> 
Items 
( 
) 
{ 
return 
new 
List 
< 
Item 
> 
{ 
new  #
Item$ (
(( )
)) *
}+ ,
;, -
} 
public 

bool 
Any 
( 
string 
name 
)  
{ 
return 
false 
; 
} 
} Ò
`C:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\Controllers\ItemsController.cs
	namespace 	
TemizKodunOnemi
 
. 
AdvancedOrnek '
.' (
WebApi( .
.. /
Controllers/ :
;: ;
[ 
Route 
( 
$str "
)" #
]# $
[		 
ApiController		 
]		 
public

 
class

 
ItemsController

 
:

 
ControllerBase

 -
{ 
private 
readonly  
ApplicationDbContext )
_context* 2
;2 3
public 

ItemsController 
(  
ApplicationDbContext /
context0 7
)7 8
{ 
_context 
= 
context 
; 
} 
[ 
HttpGet 
] 
public 

IActionResult 
GetAll 
(  
)  !
{ 
var 
items 
= 
_context 
. 
Items "
(" #
)# $
.$ %
Select% +
(+ ,
s, -
=>. 0
new1 4
ItemListDto5 @
(@ A
sA B
.B C
IdC E
,E F
sG H
.H I
NameI M
)M N
)N O
;O P
return 
Ok 
( 
items 
) 
; 
} 
[ 
HttpPost 
] 
public 

IActionResult 
Create 
(  
CreateItemDto  -
request. 5
)5 6
{ 
var 
isNameExist 
= 
_context "
." #
Any# &
(& '
request' .
.. /
Name/ 3
)3 4
;4 5
if 

( 
isNameExist 
) 
{ 	
throw   
new   )
ItemNameAlreadyExistException   3
(  3 4
)  4 5
;  5 6
}!! 	
Item## 
item## 
=## 
new## 
(## 
)## 
{$$ 	
Id%% 
=%% 
$num%% 
,%% 
Name&& 
=&& 
request&& 
.&& 
Name&& 
,&&  
}'' 	
;''	 

_context)) 
.)) 
Add)) 
()) 
item)) 
))) 
;)) 
_context** 
.** 
SaveChanges** 
(** 
)** 
;** 
return++ 
Ok++ 
(++ 
new++ 
{++ 
Id++ 
=++ 
item++ !
.++! "
Id++" $
}++% &
)++& '
;++' (
},, 
}-- °
WC:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\DTOs\CreateItemDto.cs
	namespace 	
TemizKodunOnemi
 
. 
AdvancedOrnek '
.' (
WebApi( .
.. /
DTOs/ 3
;3 4
public 
sealed 
record 
CreateItemDto "
(" #
string# )
Name* .
). /
;/ 0Ü
UC:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\DTOs\ItemListDto.cs
	namespace 	
TemizKodunOnemi
 
. 
AdvancedOrnek '
.' (
WebApi( .
.. /
DTOs/ 3
;3 4
public 
sealed 
record 
ItemListDto  
(  !
int 
Id 

,
 
string 

Name 
) 
; €
mC:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\Exceptions\ItemNameAlreadyExistException.cs
	namespace 	
TemizKodunOnemi
 
. 
AdvancedOrnek '
.' (
WebApi( .
.. /

Exceptions/ 9
;9 :
public 
class )
ItemNameAlreadyExistException *
:+ ,
	Exception- 6
{ 
public 
)
ItemNameAlreadyExistException (
(( )
)) *
:+ ,
base- 1
(1 2
$str2 K
)K L
{ 
} 
}		 ·
cC:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\Middleware\ExceptionMiddleware.cs
	namespace 	
TemizKodunOnemi
 
. 
AdvancedOrnek '
.' (
WebApi( .
.. /

Middleware/ 9
;9 :
public 
sealed 
class 
ExceptionMiddleware '
:( )
IMiddleware* 5
{ 
public 

async 
Task 
InvokeAsync !
(! "
HttpContext" -
context. 5
,5 6
RequestDelegate7 F
nextG K
)K L
{		 
try

 
{ 
await 
next	 
( 
context 
) 
; 
} 
catch 
( 	
	Exception	 
ex 
) 
{ 
context 

.
 
Response 
. 

StatusCode 
=  
$num! $
;$ %
context 

.
 
Response 
. 
ContentType 
=  !
$str" 4
;4 5
await 
context	 
. 
Response 
. 

WriteAsync $
($ %
new% (
ErrorResult) 4
(4 5
ex5 7
.7 8
Message8 ?
)? @
.@ A
ToStringA I
(I J
)J K
,K L
CancellationTokenM ^
.^ _
None_ c
)c d
;d e
} 
} 
} 
public 
sealed 
record 
ErrorResult  
(  !
string! '
Message( /
)/ 0
;0 1ä
fC:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\Middleware\GlobalExceptionHandler.cs
	namespace 	
TemizKodunOnemi
 
. 
AdvancedOrnek '
.' (
WebApi( .
.. /

Middleware/ 9
;9 :
public 
sealed 
class "
GlobalExceptionHandler *
:+ ,
IExceptionHandler- >
{ 
public 

async 
	ValueTask 
< 
bool 
>  
TryHandleAsync! /
(/ 0
HttpContext		 
httpContext		 
,		  
	Exception

 
	exception

 
,

 
CancellationToken 
cancellationToken +
)+ ,
{ 
httpContext 
. 
Response 
. 

StatusCode '
=( )
$num* -
;- .
if 

(
 
	exception 
. 
GetType 
( 
) 
== !
typeof" (
(( ))
ItemNameAlreadyExistException) F
)F G
)G H
{ 	
httpContext 
. 
Response  
.  !

StatusCode! +
=, -
$num. 1
;1 2
} 	
httpContext 
. 
Response 
. 
ContentType (
=) *
$str+ =
;= >
await 
httpContext 
. 
Response "
." #

WriteAsync# -
(- .
new. 1
ErrorResult2 =
(= >
	exception> G
.G H
MessageH O
)O P
.P Q
ToStringQ Y
(Y Z
)Z [
,[ \
cancellationToken] n
)n o
;o p
return 
true 
; 
} 
} ç
PC:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\Models\Item.cs
	namespace 	
TemizKodunOnemi
 
. 
AdvancedOrnek '
.' (
WebApi( .
.. /
Models/ 5
;5 6
public 
sealed 
class 
Item 
{ 
public 

int 
Id 
{ 
get 
; 
set 
; 
} 
public 

string 
Name 
{ 
get 
; 
set !
;! "
}# $
=% &
string' -
.- .
Empty. 3
;3 4
} ž
LC:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\Program.cs
var 
builder 
= 
WebApplication 
. 
CreateBuilder *
(* +
args+ /
)/ 0
;0 1
builder		 
.		 
Services		 
.		 -
!AddFluentValidationAutoValidation		 2
(		2 3
)		3 4
;		4 5
builder

 
.

 
Services

 
.

 %
AddValidatorsFromAssembly

 *
(

* +
Assembly

+ 3
.

3 4 
GetExecutingAssembly

4 H
(

H I
)

I J
)

J K
;

K L
builder 
. 
Services 
. 
AddCors 
( 
opt 
=> 
{ 
opt 
. 
AddDefaultPolicy 
( 
policy 
=>  "
{ 
policy 
. 
AllowAnyHeader 
( 
) 
.  
AllowAnyMethod  .
(. /
)/ 0
.0 1
WithOrigins1 <
(< =
$str= T
)T U
;U V
} 
) 
; 
} 
) 
; 
builder 
. 
Services 
. 
AddExceptionHandler $
<$ %"
GlobalExceptionHandler% ;
>; <
(< =
)= >
;> ?
builder 
. 
Services 
. 
AddProblemDetails "
(" #
)# $
;$ %
builder 
. 
Services 
. 
	AddScoped 
<  
ApplicationDbContext /
>/ 0
(0 1
)1 2
;2 3
builder 
. 
Services 
. 
AddControllers 
(  
)  !
;! "
builder 
. 
Services 
. #
AddEndpointsApiExplorer (
(( )
)) *
;* +
builder 
. 
Services 
. 
AddSwaggerGen 
( 
)  
;  !
var 
app 
= 	
builder
 
. 
Build 
( 
) 
; 
if   
(   
app   
.   
Environment   
.   
IsDevelopment   !
(  ! "
)  " #
)  # $
{!! 
app"" 
."" 

UseSwagger"" 
("" 
)"" 
;"" 
app## 
.## 
UseSwaggerUI## 
(## 
)## 
;## 
}$$ 
app&& 
.&& 
UseHttpsRedirection&& 
(&& 
)&& 
;&& 
app(( 
.(( 
UseCors(( 
((( 
)(( 
;(( 
app** 
.** 
UseExceptionHandler** 
(** 
)** 
;** 
app,, 
.,, 
UseAuthorization,, 
(,, 
),, 
;,, 
app.. 
... 
MapControllers.. 
(.. 
).. 
;.. 
app00 
.00 
Run00 
(00 
)00 	
;00	 
›
fC:\Tersan\TemizKod-CleanCode\TemizKodunOnemi.AdvancedOrnek.WebApi\Validators\CreateItemDtoValidator.cs
	namespace 	
TemizKodunOnemi
 
. 
AdvancedOrnek '
.' (
WebApi( .
.. /

Validators/ 9
;9 :
public 
sealed 
class "
CreateItemDtoValidator *
:+ ,
AbstractValidator- >
<> ?
CreateItemDto? L
>L M
{ 
public 
"
CreateItemDtoValidator !
(! "
)" #
{		 
RuleFor

 
(

 
p

 
=>

 
p

 
.

 
Name

 
)

 
.

 
NotEmpty

 $
(

$ %
)

% &
.

& '
WithMessage

' 2
(

2 3
$str

3 V
)

V W
;

W X
} 
} 