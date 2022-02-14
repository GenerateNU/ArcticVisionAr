import os
os.environ.setdefault('DJANGO_SETTINGS_MODULE', 'ArcticVisionApp.settings')
import django
django.setup()
import django.contrib.staticfilesapi

from api.models import ArcticVisiomUser

a = ArcticVisiomUser(username='a', first_name='a', last_name='a', email='a@a.com', password='a', phone='69420')
a.save()

print(ArcticVisiomUser.objects.all())