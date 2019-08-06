appcenter login --token "0469ed8ec3cfad43e95f1981f07ece88d543bc48"

ls $APPCENTER_SOURCE_DIRECTORY

appcenter test run uitest --app "Credit-Card-Team/Credit-Card-App" --devices "Credit-Card-Team/pixels" --app-path $APPCENTER_OUTPUT_DIRECTORY/com.xamarin.example.creditcardvalidator.apk --test-series "master" --locale "en_US" --build-dir $APPCENTER_SOURCE_DIRECTORY/CreditCardValidator.Droid/bin/Release  --uitest-tools-dir $APPCENTER_SOURCE_DIRECTORY/packages/Xamarin.UITest.2.2.6/tools